using RandomTest;
using System.Security.Cryptography;

var rng = RandomNumberGenerator.Create();

byte[] rBytes = new byte[4];

rng.GetBytes(rBytes);

int randomNumber = BitConverter.ToInt32(rBytes, 0);

//RunBenchmark(RandomGenerator, "RandomGenerator");

//RunBenchmark(TrueRandomGenerator, "TrueRandomGenerator");

string encrypt = Encrypter.Encrypt("Hello");

Console.WriteLine(encrypt);

string decrypt = Encrypter.Decrypt(encrypt);

Console.WriteLine(decrypt);


// ------------------------------------------------

void RandomGenerator()
{
    for (int i = 0; i < 1000000; i++)
    {
        Random rand = new Random();

        rand.Next(999);
    }
}

void TrueRandomGenerator()
{
    for (int i = 0; i < 1000000; i++)
    {
        var rand = RandomNumberGenerator.GetInt32(1000);
    }
}

// ------------------------------

void RunBenchmark(Action benchmarkMethod, string methodName)
{
    long startTime = DateTime.Now.Ticks;
    benchmarkMethod();
    long endTime = DateTime.Now.Ticks;
    long elapsedTime = endTime - startTime;
    Console.WriteLine($"{methodName} tid (ticks): {elapsedTime}");
}

// ------------------------------

