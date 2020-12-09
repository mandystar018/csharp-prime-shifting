- user inputs a number

- program returns a range of numbers from 2 to that number

- this range ONLY includes prime numbers (example: 2, 3, 5, 7, 11, ...)



program functionality (expected):
- create a range of numbers from 2 to user's number
-- range is initially inclusive of all numbers (2, 3, 4, 5, 6, ...)
-- calculations are performed on this range of numbers to remove integers that can be divided by numbers other than itself & 1

---- likely: set some common if/else parameters to remove numbers that match specific patterns
example: remove all numbers that end in "5" or in "0", because those are all divisible by 5; remove all even numbers, because those are all divisible by 2, etc.

-- example: remove 4 because it is 2x2; remove 6 because it is 2x3, remove 9 because it is 3x3, etc



---- calculations possible:
- take all numbers and divide by previous numbers, check for remainders (modulo)
- check multiples of a given number, remove all numbers elsewhere in the array that match that output
like: start at 2, multiply 2 by (x+1) until hit (user input number), compare all multiples of 2 with array, remove all 1-to-1 matches.
array: 2, 3, 4, 5, 6, 7, 8, 9, 10
2 * (x+1, starting at x=1): 4, 6, 8, 10
matches: 4, 6, 8, 10
result: 2, 3, 5, 7, 9

repeat for 3, etc

