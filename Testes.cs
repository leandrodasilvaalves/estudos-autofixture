using System;
using AutoFixture;
using Xunit;
using AutoFixture.Xunit;

namespace UsingAutoFixture
{
    public class UnitTest1
    {
        Fixture fixture = new Fixture();

        [Fact]
        public void Test1()
        {
            var autoGeneratedText = fixture.Create<string>();
            Assert.NotNull(autoGeneratedText);
            Console.WriteLine(autoGeneratedText);
            // out: e934b5a7-c18b-4263-85c5-39fce90ce0bb
        }

        [Fact]
        public void Test2()
        {
            var autoGeneratedText = fixture.Create("Name");
            Assert.NotNull(autoGeneratedText);
            Console.WriteLine(autoGeneratedText);
        }

        [Fact]
        public void Test3()
        {
            var autoGeneratedNumber = fixture.Create<int>();
            Assert.True(autoGeneratedNumber > 0);
            Console.WriteLine(autoGeneratedNumber);
        }

        [Fact]
        public void Test4()
        {
            var autoGeneratedPerson = fixture.Create<Person>();
            Assert.NotNull(autoGeneratedPerson);
            Assert.NotNull(autoGeneratedPerson.Name);
            Assert.NotNull(autoGeneratedPerson.Email);
            Assert.True(autoGeneratedPerson.Age > 0);
            Console.WriteLine(autoGeneratedPerson);
            //out: Name: Name6505a679-12e7-41fd-af83-ce1954253c33 | Age: 12 | Email: Email6328edd9-8602-4a70-87b5-36ab914a9ec4
        }

        [Fact]
        public void Test5()
        {
            var myCollection = fixture.CreateMany<String>();
            foreach (var item in myCollection)
            {
                Console.WriteLine(item);
                Assert.NotNull(item);
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} | Age: {Age} | Email: {Email}";
        }
    }
}