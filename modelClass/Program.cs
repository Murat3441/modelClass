// See http// Employee class with Id, FirstName, and LastName properties
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare Employee objects by Id
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        if (employee1 is null || employee2 is null)
        {
            return false; // Handle null cases
        }

        return employee1.Id == employee2.Id;
    }

    // Overload the "!=" operator for consistency (required when overloading "==")
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create two Employee objects with different IDs
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

        // Compare the Employee objects using the overloaded "==" operator
        bool areEqual = employee1 == employee2;

        // Display the comparison result
        Console.WriteLine($"Employee1 (ID: {employee1.Id}) is equal to Employee2 (ID: {employee2.Id}): {areEqual}");
        Console.ReadLine();
    }
}
