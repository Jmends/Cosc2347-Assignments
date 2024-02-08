namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String firstName = Console.ReadLine();
            String lastName = Console.ReadLine();
            String fullName = String.Concat(firstName, lastName);
            

            String placeOfBirth = Console.ReadLine();
            

            Console.WriteLine($"Hi, my name is {firstName} {lastName} and I was born in {placeOfBirth}. It is polite to write my name like this: {fullName.ToUpper()}. My name is huge it is {fullName.Length} characters long!\n");

            String friendPoB = Console.ReadLine();
            

            String capital = Console.ReadLine();
            String capitalSliced = capital.Substring(4);

            Console.WriteLine($"Many of my friends were born in the country of {friendPoB}. It's capital is {capital}, but peple call it {capitalSliced}\n");

            double gdp = double.Parse(Console.ReadLine());
            long population = 100000;
            double gdpOutput = gdp / population;

            long widgets = 30000;
            long widgetsTotal = population * widgets;
            long worldPopulation = 7888000000;
            
            Console.WriteLine($"My country is very wealthy, with a GDP of {gdp.ToString("C")}! We have {population} citizens, and each genrates {gdpOutput.ToString("C")} of the GDP output. Each of us produces {widgets.ToString("N0")} widgets a year, for a total of {widgetsTotal} widgets per year! Many of the world's population of {worldPopulation} people will buy them!\n");

            Console.WriteLine("Here is my friend, her age and how many widgets she produced per quater last year: \n");

            String friendName = Console.ReadLine();
            byte friendAge = byte.Parse(Console.ReadLine());
            int q1 = int.Parse(Console.ReadLine());
            int q2 = int.Parse(Console.ReadLine());
            int q3 = int.Parse(Console.ReadLine());
            int q4 = int.Parse(Console.ReadLine());
            long qTotal = q1 + q2 + q3 + q4;


            Console.WriteLine($"Name:{friendName} Age:{friendAge} Q1:{q1} Q2:{q2} Q3:{q3} Q4:{q4} Total:{qTotal}\n");

            byte otherFriendAge = byte.Parse(Console.ReadLine());
            int friendAgeTotal = friendAge + otherFriendAge;
            Console.WriteLine($"Here is another friend, and he is {otherFriendAge} years old. They are a total of {friendAgeTotal} years old\n");


            String stringNumber = Console.ReadLine();
            Console.Write($"Is this String {stringNumber} a number? ");

            if (int.TryParse(stringNumber, out int convertedNumber))
            {
                Console.WriteLine(convertedNumber);
            }
            else
            {
                Console.WriteLine("No it didn't convert");
            }

            String numberString = Console.ReadLine();

            Console.Write($"Is this {numberString} a number? ");

            if (int.TryParse(numberString, out int convertNumber))
            {
                Console.WriteLine(convertNumber);
            }
            else
            {
                Console.WriteLine("No it didn't convert\n");
            }

            
            Tuple<String, int, String> actor1 = Tuple.Create("Cllian Murphy", 47, "Peaky Blinders");
            Tuple<String, int, String> actor2 = Tuple.Create("Kenneth Branagh", 63, "Death on the Nile");
            Tuple<String, int, String> actor3 = Tuple.Create("AnnaSophia Robb", 30, "Bridge to Terabithia");

            Console.WriteLine($"Actor 1: {actor1}");
            Console.WriteLine($"Actor 2: {actor2}");
            Console.WriteLine($"Actor 3: {actor3}\n");

            Tuple<int, int> numbers1 = Tuple.Create(64,300);
            Tuple<int, int> numbers2 = Tuple.Create(59,4340);
            int sum = numbers1.Item1 + numbers1.Item2 + numbers2.Item1 + numbers2.Item2;
            int product = numbers1.Item1 * numbers1.Item2 * numbers2.Item1 * numbers2.Item2;


            Console.WriteLine($"The sum and product of number tuples 1: {numbers1} and 2: {numbers2} are {sum} and {product}.\n");

            String[] dogs = {"German Sheperd", "Bulldog", "Beagle", "Rottweiler", "Basenji", "Havanese","Dobermann","Shiba Inu", "Corgi"};
            Console.WriteLine($"Dogs: {string.Join(", ", dogs)}\n");

            Console.Write("The 3rd through 5th dogs: ");
            for(int i = 2; i <=4; i++)
            {
                Console.Write($"{dogs[i]} ");
            }

        }
    }
}
