# PlingPlangPlong



## Contents

- [Introduction](#Introduction)
- [Approach](#Approach)
- [Testing](#Testing)

## Introduction

This is a small console application, written in C# as a small problem solving project. The goal of the project was to create a software which can read any valid integer and according to the factors of the number, will convert to a word, either Pling, Plang or Plong. 

The given conditions were

- Factor of 3 gives Pling
- Factor of 5 gives Plang
- Factor of 7 gives Plong

Multiples of these factors will give a combination of the the words according to which factors they contain, and if none of these numbers are factors, then the integer will be written out. For example

- 350(7*5*5*2) gives PlangPlong
- 0(7*5*3*0) gives PlingPlangPlong
- 22 gives 22 as neither 3,5 or 7 are factors of 22

## Approach

In my approach I decided to create a test and console project, in order to ensure quality. In the console project, I created a separate class for the functionality and inside made a single function, which takes the integer to convert as a parameter, and converts to a string for output.
```csharp
public static class RainDrops
{
    public static string PlingPlangPlongConvert(int number)
    {
		string ans = "";
        return ans;
    }

}
```

Then to cover the conditions I used a chain of if statements to concatenate onto the string based on the presence of a factor. This was ideal compared to if else or case statements, as each statement only has to be run once, without conditional loops or unnecessary comparisons. 

```csharp
public static class RainDrops
    {
        public static string PlingPlangPlongConvert(int number)
        {
            string ans = "";
            if(number % 3 == 0)
            {
                ans += "Pling";
            }

            if (number % 5 == 0)
            {
                ans += "Plang";
            }

            if (number % 7 == 0)
            {
                ans += "Plong";
            }

            return ans;
            
        }
    }
```

Finally, to have a returned number if none of the factors were present, I used a ternary condition statement to check if the answer string was empty or not(no factors). To return the number in this case I have to attempt a conversion to string of the number. 

Although, there should be no errors since, the method signature only allows valid inputs (single integer), I added a try catch block, in case for some reason there was an error.

```csharp
public static class RainDrops
    {
        public static string PlingPlangPlongConvert(int number)
        {
            string ans = "";
            if(number % 3 == 0)
            {
                ans += "Pling";
            }

            if (number % 5 == 0)
            {
                ans += "Plang";
            }

            if (number % 7 == 0)
            {
                ans += "Plong";
            }

            return ans;
                try
                {
                return ans != "" ? ans: number.ToString() ;
                }

                catch(Exception e)
                {
                    return "Not a valid input.";
                {
        }
    }
```

## Testing

For testing I used the Nunit testing framework, which allows creation of set up, testcases and teardowns. 

### Test design

For each test I named it according to the class of input, number and the desired result to make things clear and tracible. I also included a number parameter for each test so the test itself can have its inputs easily changed, when creating individual test cases.

The Assert object  provided by NUnit, gives the conditions of verification of the test through the method chosen.. In my tests I used the Are equal as it was the simplest way to write these equivalence tests. In the below example the test will pass if the value given by the convert method is equal to the string I have provided. 


```csharp
public void DivisibleBy7And5GivesPlangPlong(int number)
        {
            Assert.AreEqual(rainDrops.PlingPlangPlongConvert(number), "PlangPlong");
        }
```

Each test was designed like above  apart from the test for numbers which don't have any factors, shown below.

```csharp
public void InvalidNumbersDontWork(int number)
        {
            Assert.AreEqual(rainDrops.PlingPlangPlongConvert(number), number.ToString());
        }
```

### Test cases
To fully test the functionality I wanted to have full path coverage of factors and cover corner and edge cases, meaning  examples for each  factor and combinations, as well as no factors. While I cannot test every single possible number combination, I can give representative values for the types of values, e.g. negative numbers, large numbers, etc. For example for my test case for multiples of 5 and 7, giving PlangPlong

```csharp
[TestCase(35)]
[TestCase(-350000)]
[TestCase(-35)]
[TestCase(350)]
        
public void DivisibleBy7And5GivesPlangPlong(int number)
    {
        Assert.AreEqual(rainDrops.PlingPlangPlongConvert(number), "PlangPlong");
    }
```
