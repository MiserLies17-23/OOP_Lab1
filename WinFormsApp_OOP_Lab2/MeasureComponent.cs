using System.Diagnostics;
using WinFormsApp_OOP_Lab1.Model;

namespace WinFormsApp_OOP_Lab2
{
    public static class MeasureComponent
    {
        private static readonly Stopwatch STOPWATCH = new();

        private static readonly Random RND = new();

        private static readonly int SIZE = 100_000;

        private static List<Person> PERSONS = new(SIZE);

        private static PersonStack PERSON_STACK = new(SIZE);

        private static Person[] ARRAY = new Person[SIZE];

        public static int InsertInStack()
        {
            PERSON_STACK.Clear();
            STOPWATCH.Reset();
            STOPWATCH.Start();
            for (int i = 0; i < SIZE; i++)
                PERSON_STACK.AddItem(RandomValuesGenerator.CreateRandomPerson());
            STOPWATCH.Stop();
            return (int)STOPWATCH.ElapsedMilliseconds;
        }

        public static int InsertInArray()
        {
            Array.Clear(ARRAY);
            STOPWATCH.Reset();
            STOPWATCH.Start();
            for (int i = 0; i < SIZE; i++)
                ARRAY[i] = (RandomValuesGenerator.CreateRandomPerson());
            STOPWATCH.Stop();
            return (int)STOPWATCH.ElapsedMilliseconds;
        }

        public static int ConsistentStackSelection()
        {
            PERSONS.Clear();
            STOPWATCH.Reset();
            STOPWATCH.Start();
            for (int i = 0; i < SIZE; i++)
                PERSONS.Add(PERSON_STACK.Stack.First()); // исправить
            STOPWATCH.Stop();
            return (int)STOPWATCH.ElapsedMilliseconds;
        }

        public static int ConsistentArraySelection()
        {
            PERSONS.Clear();
            STOPWATCH.Reset();
            STOPWATCH.Start();
            for (int i = 0; i < SIZE; i++)
                PERSONS.Add(ARRAY[i]);
            STOPWATCH.Stop();
            return (int)STOPWATCH.ElapsedMilliseconds;
        }

        public static int RandomStackSelection()
        {
            PERSONS.Clear();
            var personArray = PERSON_STACK.Stack.ToArray();
            STOPWATCH.Reset();
            STOPWATCH.Start();
            for (int i = 0; i < SIZE; i++)
                PERSONS.Add(personArray[RND.Next(SIZE - 1)]);
            STOPWATCH.Stop();
            return (int)STOPWATCH.ElapsedMilliseconds;
        }

        public static int RandomArraySelection()
        {
            PERSONS.Clear();
            STOPWATCH.Reset();
            STOPWATCH.Start();
            for (int i = 0; i < SIZE; i++)
                PERSONS.Add(ARRAY[RND.Next(SIZE - 1)]);
            STOPWATCH.Stop();
            return (int)STOPWATCH.ElapsedMilliseconds;
        }
    }
}
