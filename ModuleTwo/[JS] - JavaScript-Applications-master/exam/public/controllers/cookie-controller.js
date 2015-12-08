var cookieController = function(){
    var wantedurl;

    function isValidCookieData(data){
        if(typeof data !== 'string'){
            return false;
        }

        if(data.length < 6 || data.length > 30){
            return false;
        }

        return true;
    }

    function isValidUrl(url){
        if(typeof url !== 'string'){
            return false;
        }

        if(/(http|ftp|https):\/\/[\w-]+(\.[\w-]+)+([\w.,@?^=%&amp;:\/~+#-]*[\w@?^=%&amp;\/~+#-])?/.test(url)){
            return false;
        }

        return true;
    }

    function showHideData(){
        if(data.users.hasUser()){
            $('div.special').css('display', 'block');
        }
        else{
            $('div.special').css('display', 'none');
        }
    }

    function initializeCategories(allCookies){
        var $select = $('#categories');

        var categories = _.chain(allCookies).map(function(cookie){
            return cookie.category;
        }).uniq(function(element){
            return element;
        }).value();

        for(var index in categories){
            var $option = $('<option />').html(categories[index]);
            $select.append($option);
        }

        $('#showSelectedCategory').on('click', function(context){
            wantedurl = $('#categories option:selected').text();
        });
    }

    function share(cookieText, cookieCategory, url){
        if(!isValidUrl(url)){
            url = 'https://dayinthelifeofapurpleminion.files.wordpress.com/2014/12/batman-exam.jpg';
        }

        if(!isValidCookieData(cookieText) || !(isValidCookieData(cookieCategory))){
            toastr.error('Invalid cookie text or category');
            return;
        }

        var dataInfo = {
            text: cookieText,
            category: cookieCategory,
            img: url
        };

        data.fortuneCookies.post(dataInfo)
            .then(function(){
                toastr.success('successfully posted!');
            })
            .catch(function(err){
            toastr.error(err);
        });
    }

    function all(context){
        var fortuneCookies;
        data.fortuneCookies.get()
            .then(function(respCookies){
                fortuneCookies = respCookies;
                //localStorage.setItem('allCookies', JSON.stringify(fortuneCookies));
                return templates.get('fortuneCookies');
            })
            .then(function(template){
                context.$element().html(template(fortuneCookies));

                $('#likesSortButton').on('click', function(){
                    var currentFortuneCookies = _.sortBy(fortuneCookies, function(fortuneCookie){
                        return fortuneCookie.likes;
                    });

                    context.$element().html(template(currentFortuneCookies));

                    showHideData();
                });

                $('#dateSortButton').on('click', function(){
                    $this = $(this);
                    var sortedByDate = _.sortBy(fortuneCookies, function(fortuneCookie){
                        var date = new Date(fortuneCookie.shareDate);
                        return date;
                    });
                    //var fortuneCookies = JSON.parse(localStorage.getItem('allCookies'));

                    context.$element().html(template(sortedByDate));
                    showHideData();
                });

                $('#allCookies').on('click', 'button.share', function(){
                    $this = $(this);
                    //var fortuneCookies = JSON.parse(localStorage.getItem('allCookies'));
                    var currentCookie = fortuneCookies[+$this.attr('data-info')];
                    share(currentCookie.text, currentCookie.category, currentCookie.img);
                });

                $('#allCookies').on('click', 'button.like', function(){
                    $this = $(this);
                    //var fortuneCookies = JSON.parse(localStorage.getItem('allCookies'));
                    var currentCookie = fortuneCookies[+$this.attr('data-info')];
                    data.fortuneCookies.put('like', currentCookie.id)
                        .then(function(){
                            toastr.success('Liked');
                        })
                        .catch(function(err){
                            console.log(err);
                        });
                });

                $('#allCookies').on('click', 'button.dislike', function(){
                    $this = $(this);
                    //var fortuneCookies = JSON.parse(localStorage.getItem('allCookies'));
                    var currentCookie = fortuneCookies[+$this.attr('data-info')];
                    data.fortuneCookies.put('dislike', currentCookie.id)
                        .then(function(){
                            toastr.warning('Disliked!');
                        })
                        .catch(function(err){
                            console.log(err);
                        });
                });

                initializeCategories(fortuneCookies);

                showHideData();
            })
            .catch(function(err) {
                console.log(err);
            });
    }

    function shareNewCookie(context){
        templates.get('shareCookie')
            .then(function(template){
                context.$element().html(template);

                $('#shareButton').on('click', function(){
                    var $cookieText = $('#cookieTextArea').val(),
                        $cookieCategory = $('#cookieCategoryInput').val(),
                        $url = $('#urlImageInput').val();

                        share($cookieText, $cookieCategory, $url);
                });
            });
    }

    return {
        allCookies: all,
        share: shareNewCookie,
        wantedurl: wantedurl
    };
}();
