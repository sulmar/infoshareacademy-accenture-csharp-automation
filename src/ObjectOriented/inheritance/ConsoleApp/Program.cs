Console.WriteLine("Hello, World!");

Compressor compressor = new OilCompressor("C-01");

Valve valve1 = new Valve("V-11");
Valve valve2 = new Valve("V-22");

Mixer mixer = new Mixer("M-03", Direction.Left, valve1, valve2);
mixer.Start(Direction.Right);
mixer.Stop();

Machine machine1 = compressor; // referencja (wskaźnik do zmiennej silnie typowany)
machine1.Start();
machine1.Stop();


Console.WriteLine("Uruchomienie linii produkcyjnej");

// Lista obiektów typu Machine
List<Machine> productionLineA = new List<Machine>();
productionLineA.Add(compressor);
productionLineA.Add(mixer);
productionLineA.Add(new Boxing("P-01"));

foreach (Machine m in productionLineA)
{
    m.Start();
}

foreach (Machine m in productionLineA)
{
    m.Stop();
}
