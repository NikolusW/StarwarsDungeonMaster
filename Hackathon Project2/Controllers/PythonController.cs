using System;
//using Python.Runtime;

namespace CallPythonFromCSharp
{
    class PythonController
    {
        static void Main(string[] args)
        {
            string pythonScriptPath = "path/to/OpenAI.py";

            /*
            using (Py.GIL()) // Acquire the Python GIL (Global Interpreter Lock)
            {
                dynamic py = Py.Import("__main__");
                py.exec(File.ReadAllText(pythonScriptPath));

               string test = "this is a test. Respond accordingly";

                dynamic result = py.CustomChatGPT(test);
                Console.WriteLine($"Result: {result}");
            }
            */
        }
    }
}


//hello
//hello
