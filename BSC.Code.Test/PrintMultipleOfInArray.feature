@tfs:https://wservices.visualstudio.com/BSC_Case_Test
Feature: PrintMultipleOfInArray
	I order to run a Loop between 1 and 100
	I want to print wicht ones are multiple of 3
	Or to print wicht ones are multiple of 3 and ends in 6
	Or to print wicht ones only ends in 6
	
@tc:1
@myScenarios
Scenario: Print items of the array
	Given an array of integers between 1 and 100
	When item is multiple of 3
	And The array have following items
    | item |
	| 3      |
	| 9      |
	Then should print item 
    | item | message      |
    | 3    | multiple of 3 |
    | 9    | multiple of 3 |
    