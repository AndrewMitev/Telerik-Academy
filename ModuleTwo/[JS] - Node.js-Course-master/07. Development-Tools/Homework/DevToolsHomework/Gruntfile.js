module.exports = function (grunt) {

    grunt.initConfig({
        project: {
            app: 'app'
        },
        copy: {
            images:{
                files: [{
                    expand: true,
                    cwd: 'APP/images/',
                    src: ['**/*.{png,jpg,svg}'],
                    dest: 'DEV/images/'
                }]
            },
            distImages: {
                files: [{
                    expand: true,
                    cwd: 'DEV/images/',
                    src: ['**/*.{png,jpg,svg}'],
                    dest: 'DIST/images/'
                }]
            }
        },
        coffee: {
          compile: {
              files: {
                  'DEV/scripts.js' : 'APP/test.coffee'
              }
          }
        },
        watch: {
            js: {
                files: ['DEV/**/*.js'],
                tasks: ['jshint'],
                options: {
                    livereload: true
                }
            },
            jade: {
              files: ['APP/**/*.jade'],
              task: ['jade'],
            },
            styles: {
                files: ['<%= project.app %>/styles/**/*.styl'],
                tasks: ['stylus'],
                options: {
                    livereload: true
                }
            },
            livereload: {
                options: {
                    livereload: '35729'
                },
                files: [
                    'DEV/**/*.html',
                    'DEV/**/*.css',
                    'DEV/**/*.styl'
                ]
            }
        },
        connect: {
            options: {
                port: 9578,
                livereload: 35729,
                hostname: 'localhost'
            },
            livereload: {
                options: {
                    open: true,
                    base: [
                        'DEV/'
                    ]
                }
            }
        },
        jshint: {
            all: [
                'Gruntfile.js',
                'DEV/**/*.js'
            ]
        },
        jade: {
            compile: {
                options: {
                    data: {
                        debug: false
                    }
                },
                files: {
                    'DEV/test.html' : 'APP/test.jade'
                }
            }
        },
        stylus: {
            compile: {
                files: {
                    'DEV/styles/main.css': 'APP/test.styl'
                }
            }
        },
        csslint: {
            strict: {
                options: {
                    import: false
                },
                src: ['DEV/styles/**/*.css']
            },
            lax: {
                options: {
                    import: false
                },
                src: ['DEV/styles/**/*.css']
            }
        },
        concat: {
            js: {
                files: {
                    'DIST/build.js': ['DEV/**/*.js']
                }
            },
            css: {
                files: {
                    'DIST/styles/build.css': ['DEV/styles/**/*.css']
                }
            }
        },
        cssmin: {
            css: {
                files: {
                    'DIST/styles/build.min.css': 'DIST/styles/build.css'
                }
            }
        },
        uglify: {
            js: {
                files: {
                    'DIST/build.min.js': 'DIST/build.js'
                }
            },
            html: {
                files: {
                    'DIST/uglyHtml.html': 'DEV/test.html'
                }
            }
        },
    });

    grunt.loadNpmTasks('grunt-contrib-coffee');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-jade');
    grunt.loadNpmTasks('grunt-contrib-connect');
    grunt.loadNpmTasks('grunt-contrib-stylus');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-contrib-csslint');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-contrib-uglify');

    grunt.registerTask('serve', ['coffee', 'jshint', 'jade', 'stylus','copy:images', 'connect', 'watch']);
    grunt.registerTask('build', ['coffee', 'stylus', 'jade', 'jshint', 'csslint', 'concat:css', 'cssmin', 'concat:js', 'uglify:js', 'uglify:html', 'copy:distImages']);
};
