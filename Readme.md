Assumptions:
1. Shoes are equivalent to Boots
2. Pants must be put on before shoes : This statement implies that sandals can be put on before pants;
3. All commands must be unique in the input given. If not, the process will fail. It also covers below statement
	:Only 1 piece of each type of clothing may be put on 
4. To get clothing commands, all the commands with description starting with "Put on" are considered.


## Project Structure:
## Dressing.Business:
	1. To add a new temperature type (e.g. MODERATE):
	i) new class needs to be added in TemperatureStrategies folder by implementing TemperatureStrategy class
	ii) new enum value to be added to TemperatureType enum
	iii) StrategyResolver.GetTemperatureStrategy needs to be modified 
	2. To add/remove a new command
	i) apply required modifications to rules inside rules folder
	ii) Commands enum to be modified
	3. Any rule can be added or removed easily for a temperature type in the method TemperatureStrategy.InitializeRules
## Dressing.Tests:
	1. All the tests given in the examples are covered and some additional test cases are added

## Dressing.Console:
	1. This project can be used to see the output for a given example in a console

	