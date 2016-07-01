function solve(args){


	 function getCountOfSubstring(substring, text) {
	 		if (substring == '' || text == ''){
	 			return 0;
	 		}

	 		substring = substring.toLowerCase();
	 		text = text.toLowerCase();

	 		let index = text.indexOf(substring), count = 0;

		    if (index === -1){
		    	return 0;
		    }
		    else{
		    	count = 1;
	    		while (index !== -1){	    			
	    			index = text.indexOf(substring, index + 1);

	    			if (index !== -1){
	    				count += 1;
	    			}
	    		}

	    		return count;
		    }
	}

    console.log(getCountOfSubstring(args[0], args[1]));
}

solve([
    'in',
    'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
]);
