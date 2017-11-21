﻿
using System;
using System.IO;
using NUnit.Framework;
using Trivia;

namespace TriviaTests
{
    [TestFixture]
    public class UnitTest1
    {
        private const string Expected = @"Chet was added
They are player number 1
Pat was added
They are player number 2
Sue was added
They are player number 3
Chet is the current player
They have rolled a 5
Chet's new location is 5
The category is Science
Science Question 0
Answer was corrent!!!!
Chet now has 1 Gold Coins.
Pat is the current player
They have rolled a 4
Pat's new location is 4
The category is Pop
Pop Question 0
Answer was corrent!!!!
Pat now has 1 Gold Coins.
Sue is the current player
They have rolled a 1
Sue's new location is 1
The category is Science
Science Question 1
Answer was corrent!!!!
Sue now has 1 Gold Coins.
Chet is the current player
They have rolled a 3
Chet's new location is 8
The category is Pop
Pop Question 1
Answer was corrent!!!!
Chet now has 2 Gold Coins.
Pat is the current player
They have rolled a 4
Pat's new location is 8
The category is Pop
Pop Question 2
Answer was corrent!!!!
Pat now has 2 Gold Coins.
Sue is the current player
They have rolled a 2
Sue's new location is 3
The category is Rock
Rock Question 0
Answer was corrent!!!!
Sue now has 2 Gold Coins.
Chet is the current player
They have rolled a 2
Chet's new location is 10
The category is Sports
Sports Question 0
Question was incorrectly answered
Chet was sent to the penalty box
Pat is the current player
They have rolled a 5
Pat's new location is 1
The category is Science
Science Question 2
Answer was corrent!!!!
Pat now has 3 Gold Coins.
Sue is the current player
They have rolled a 1
Sue's new location is 4
The category is Pop
Pop Question 3
Question was incorrectly answered
Sue was sent to the penalty box
Chet is the current player
They have rolled a 1
Chet is getting out of the penalty box
Chet's new location is 11
The category is Rock
Rock Question 1
Answer was correct!!!!
Chet now has 3 Gold Coins.
Pat is the current player
They have rolled a 2
Pat's new location is 3
The category is Rock
Rock Question 2
Answer was corrent!!!!
Pat now has 4 Gold Coins.
Sue is the current player
They have rolled a 5
Sue is getting out of the penalty box
Sue's new location is 9
The category is Science
Science Question 3
Answer was correct!!!!
Sue now has 3 Gold Coins.
Chet is the current player
They have rolled a 4
Chet is not getting out of the penalty box
Pat is the current player
They have rolled a 3
Pat's new location is 6
The category is Sports
Sports Question 1
Answer was corrent!!!!
Pat now has 5 Gold Coins.
Sue is the current player
They have rolled a 3
Sue is getting out of the penalty box
Sue's new location is 0
The category is Pop
Pop Question 4
Answer was correct!!!!
Sue now has 4 Gold Coins.
Chet is the current player
They have rolled a 5
Chet is getting out of the penalty box
Chet's new location is 4
The category is Pop
Pop Question 5
Answer was correct!!!!
Chet now has 4 Gold Coins.
Pat is the current player
They have rolled a 1
Pat's new location is 7
The category is Rock
Rock Question 3
Answer was corrent!!!!
Pat now has 6 Gold Coins.";

        private const string directoryPathe =
            @"C:\Users\Christina\Source\Repos\LegacyCodeRetreat\trivia\C#\Trivia\TriviaTests";
        [Test]
        public void TestMethod1()
        {
            var actual = "";
            var expected = "";
/*            using (var fileStream =
                new FileStream(directoryPathe + @"\GameOutputs\CapturedOutput.txt", FileMode.OpenOrCreate))
            {
                using (StringWriter reader = new StringWriter(fileStream))
                {
                    
                }
            }*/
            expected = File.ReadAllText(directoryPathe + @"\GameOutputs\CapturedOutput.txt");

            using (StringWriter writer = new StringWriter())
            {
                Console.SetOut(writer);
                GameRunner.Main(new String[] { });
                actual = writer.ToString();
            }
            Assert.AreEqual("bladibla",actual);
        }
    }
}