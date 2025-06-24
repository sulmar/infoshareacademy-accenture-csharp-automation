using System.IO;

Console.WriteLine("Hello, World!");

while (true)
{
    ErrorLogger errorLogger = new ErrorLogger();

    Console.Write("Podaj nazwę pliku: ");
    string filename = Console.ReadLine();

    int counter = 0;

    try
    {
        string data = File.ReadAllText(filename);
        counter++;

        var chunks = 10 / data.Length;
        counter++;

        Console.WriteLine(data);
    }
    catch(Exception e)
    {
        errorLogger.LogException(e);
    }


    // FileNotFoundException : IOException : Exception

    //catch (FileNotFoundException e)
    //{
    //    Console.WriteLine($"Plik {e.FileName} nie istnieje.");
    //}
    //catch (IOException)
    //{
    //    Console.WriteLine("Wystąpił wyjątek operacji I/O");
    //}
    //catch (Exception e)
    //{
    //    Console.WriteLine($"Wystąpił inny wyjątek: {e.Message}");
    //}
    finally
    {
        Console.WriteLine("Zakończono próbę odczytu pliku.");
    }
}


class ErrorLogger
{
    public void LogException(Exception exception)
    {
        if (exception is FileNotFoundException e)
        {
            Console.WriteLine($"Plik {e.FileName} nie istnieje.");
        }
        else
        if (exception is IOException iOException)
        {
            Console.WriteLine($"Wystąpił wyjątek operacji I/O: {iOException.Message}");
        }
        else
        {
            Console.WriteLine($"Wystąpił inny wyjątek: {exception.Message}");
        }

    }
}