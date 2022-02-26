Feature: Romanizing

@mytag
Scenario Outline: Romanizing
	Given input of <integer>
	When converted to Roman numerals
	Then the result should be <roman>
	Examples: 
	| integer | roman     |
	| 3       | iii       |
	| 4       | iv        |
	| 5       | v         |
	| 6       | vi        |
	| 8       | viii      |
	| 9       | ix        |
	| 10      | x         |
	| 11      | xi        |
	| 27      | xxvii     |
	| 29      | xxix      |
	| 30      | xxx       |
	| 31      | xxxi      |
	| 777     | dcclxxvii |
	| 999     | cmxcix    |
	| 1999    | mcmxcix   |
	| 2021    | mmxxi     |
	| 4000    | Exception |
	| -1      | Exception |
	| -100    | Exception |
	| 0       |           |


