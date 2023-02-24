namespace Keymap; 

public class Program {

    public static string Test { get; set; } = "Hello World!";
    
    public static void Main(string[] args) {
        Console.WriteLine("Hello World!");

        if(true) {
          Console.WriteLine("Hello World!");  
        }

        while (true) {
            Console.WriteLine("Hello World!");
            break;
        }
        
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Hello World!");
        }
        
        foreach (var item in args) {
            Console.WriteLine("Hello World!");
        }
        
        switch (args.Length) {
            case 0:
                Console.WriteLine("Hello World!");
                break;
            case 1:
                Console.WriteLine("Hello World!");
                break;
            default:
                Console.WriteLine("Hello World!");
                break;
        }
        
        try {
            Console.WriteLine("Hello World!");
        } catch (Exception ex) {
            Console.WriteLine("Hello World!");
        } finally {
            Console.WriteLine("Hello World!");
        }
        
        using (var stream = new FileStream("test.txt", FileMode.Open)) {
            Console.WriteLine("Hello World!");
        }
        
        lock (args) {
            Console.WriteLine("Hello World!");
        }
        
        var x = 1;
        var y = 2;
        var z = 3;
        var result = x + y + z;
        Console.WriteLine(result);
        
        var result2 = x + y + z;
        
        Console.WriteLine(Test + " " + result2);
        
    }

    public static void TestFn() {
        Console.WriteLine("Hello World!");
    } 
    
    public static void TestFn2() {
        Console.WriteLine("Hello World!");
    }
    
}