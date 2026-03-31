using System;
using System.Threading.Tasks;
using AIAnalyzers.ImageClasification;

namespace AIAnalyzers
{
    class Program
    {
        //https://github.com/Azure-Samples/cognitive-services-quickstart-code/tree/master/dotnet

        //https://github.com/orgs/MicrosoftLearning/repositories?q=mslearn-ai+sort%3Astars

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World");
            await new FlowerClascification().TestIteration().ConfigureAwait(false);
        }
    }
}
