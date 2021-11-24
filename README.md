# Coding Challenges 
### This repository contains various coding challenges taken on Sites like HackerRank, LeetCode etc. 

## Challenge#1- Prefix Notation 
### Write a function that evaluates an expression written in Prefix Notiation and returrns a value 

#### Problem Statement: 

Prefix notation (also known as polish notation) is an alternative to the more familier infix notation. 

In infix notation, operators(add,multiply,etc) are written between their operands(number, variables, or sub-expression). 
* In prefix notation, operators are written before their operands
Some examples follow of expression in infix notation and their equivalents in prefix notation. 
In this example the operator is + and its operands are 1 and 2:

```
Infix expression: 1 + 2 
Prefix expression: + 1 2 
Value: 3
```

In this example, the sub-expression + 1 2 is the first operand of the + operator 

```
Infix expression: (1+2) * 3
Prefix expression: * + 1 2 3 
Value: 9 
```

Sometimes there are multiple sub-expressions:
``` 
Infix expression: ((1 + 2) *3)-4 
Prefix expression: - * + 1 2 3 4
value: 5
``` 

Sub-expressions can be nested arbitrarily deeply:
``` 
Infix expression: 6 + (( 4 - (2 + 3 ) ) * 8 )
Prefix expression: + 6 * - 4 + 2 3 8
value: -2
``` 
##### Variables
So far we have only considered numbers as our operands for the prefix expression. For this test, we would like your function to also support variables withing the expression. 

For example: 
``` 
expression: + 10 x 
variables {"x":3}
value: 13
```
#### Task

Implement a function CalculateExpression(expression,variables)
that takes as inputs:
* expression, a string containing an expression in prefix notiation that might contain variables 
* variables, a JSON objeect containing the values for each variable in the expression
and returns: 
* the result of the expression for the given values 
* throw exception the expression is invalid or if the expression does not have any valid result

The syntax supports 4 operators: +, -, *, and /. These are the standard artihmetic operators.
* Note: / denotes integer division, that is / 7 2 evaluates to 3, not 3.5. 

The only accepted numeric operands aer positive integers in base 10 (e.g 1,22, 85 are valid, -1,0x43, 0 are not valid).

A valid variable name is any sequence of characters that doesn't include whitespaces(spaces,tabs, newlines, etc). 

#### Examples

```
Expression: + 1 5
variables: {}
result: 6
```

```
Expression: + 1 2 3
variables: {}
result: 6
```

```
Expression: + 1
variables: {}
result: exception
```

```
Expression: 9
variables: {}
result: 9
```

```
Expression: * + 1 2 3
variables: {}
result: 9
```

Although, negative numeric operands are invalid in expression, intermediate and final results may be negative
```
Expression: + 6 * - 4 + 2 3 8 
variables: {}
result: -2
```

Operators and operrands must be seperated by one or more white spaces:
```
Expression: -+1 5 3
variables: {}
result: exception
```
 
```
Expression: +1       2
variables: {}
result: 3
```
Expression containing variables:

```
Expression: * + 2 x y
variables: {"x":1,"y":3}
result: 9
```

#### Solution: CodingChallenge.HackerRank/PrefixNotation.cs
#### Test Cases : CodingChallenge.Tests/UT_PrefixNotation.cs

![Test Results](https://github.com/csehammad/CodingProblems/blob/main/CodingChallenge.Tests/IMG_PrefixNotation.png?raw=true)

