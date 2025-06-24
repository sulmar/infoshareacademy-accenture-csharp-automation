
HashSet<string> devices = new HashSet<string>();

devices.Add("192.168.0.1");
devices.Add("192.168.0.2");
devices.Add("192.168.0.3");
devices.Add("192.168.0.1");
devices.Add("192.168.0.1");

foreach (var device in devices)
{
    Console.WriteLine(device);
}

if (devices.Contains("192.168.0.99"))
{
    Console.WriteLine("znaleziono");
}
else
{
    Console.WriteLine("nie znaleziono");
}



