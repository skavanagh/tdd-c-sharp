/*
# Three Laws of Test Driven Development
- You are not allowed to write any production code unless it is to make a failing unit test pass.
- You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.
- You are not allowed to write any more production code than is sufficient to pass the one failing unit test.
*/

/*
Fake it till you make it
*/

/*
# ZOMBIES
Z - Zero                          
O - One                           
M - Many
B - Boundary Behavior
I - Interface Definition          
E - Exercise Exception Behavior
S - Simple
*/

/*
PROBLEM REQUIREMENTS:
- For multiples of three set “Fizz” instead of the number
- For the multiples of five set “Buzz”. 
- For numbers which are multiples of both three and five set “FizzBuzz“.
- Otherwise set the ordinal number
**Upper bound**: 15
**Example output**: [1, 2, 'Fizz', 4, 'Buzz', 'Fizz', 7, 8, 'Fizz', 'Buzz', 11, 'Fizz', 13, 14, 'FizzBuzz']
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz;

[TestClass]
public class FizzBuzzTests
{
    [TestMethod]
    public void TestFizzBuzz()
    {
        // var fizzBuzz = new FizzBuzz();
        Assert.IsTrue(false, "Turn the checked value to true to pass this test");
    }
}