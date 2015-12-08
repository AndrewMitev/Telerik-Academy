/* 
Create a function that:
*   **Takes** an array of animals
	*   Each animal has propeties `name`, `species` and `legsCount`
*   **groups** the animals by `species`
	*   the groups are sorted by `species` descending
*   **sorts** them ascending by `legsCount`
	*	if two animals have the same number of legs sort them by name
*   **prints** them to the console in the format:

```
	----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
	GROUP_1_NAME:
	----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
	NAME has LEGS_COUNT legs //for the first animal in group 1
	NAME has LEGS_COUNT legs //for the second animal in group 1
	----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
	GROUP_2_NAME:
	----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
	NAME has LEGS_COUNT legs //for the first animal in the group 2
	NAME has LEGS_COUNT legs //for the second animal in the group 2
	NAME has LEGS_COUNT legs //for the third animal in the group 2
	NAME has LEGS_COUNT legs //for the fourth animal in the group 2
```
*   **Use underscore.js for all operations**
*/

function solve(){

	function printSpecies(groupedSpecies){
		for(var indexName in groupedSpecies){
			var lengthOfSeparator = indexName.length + 2,
                animals = groupedSpecies[indexName];

            console.log(new Array(lengthOfSeparator).join('-'));
            console.log(indexName + ':');
            console.log(new Array(lengthOfSeparator).join('-'));

            _.each(animals, function(animal){
                console.log(animal['name'] + ' has ' + animal['legsCount'] + ' legs');
            });
		}
	}

	function sortByKeys(species){
	  var sorted = Object.create({});

	  var keys = _.chain(species).keys(species).sort().reverse().value();

	  for(var index in keys){
		  var data = species[keys[index]];
		  data = sortAnimalsByLegCount(data);
		  sorted[keys[index]] = data;
	  }

	  return sorted;
	}

	function sortAnimalsByLegCount(data){
	  var sorted = _.chain(data).sortBy('name').sortBy('legsCount').value();

	  return sorted;
	}

	return function(animals) {
	  if(typeof require !== 'undefined'){
		  _ = require('../bower_components/underscore/underscore.js');
	  }

	  var groupedSpecies = _.groupBy(animals, function(animal){
		  return animal.species;
	  });

	  var sortedSpeciesByKey = sortByKeys(groupedSpecies);
        printSpecies(sortedSpeciesByKey);
	};
}

module.exports = solve;
