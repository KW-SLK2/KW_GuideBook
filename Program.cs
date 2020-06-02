using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;


//파이선을 실행하기 위해 추가
using IronPython;
using IronPython.Hosting;
using IronPython.Runtime;
using IronPython.Modules;


namespace PythonCSharpConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = IronPython.Hosting.Python.CreateEngine();
            var scope = engine.CreateScope();
            var paths = engine.GetSearchPaths();

            paths.Add(@"C:\Anaconda");
            paths.Add(@"C:\Anaconda\DLLs");
            paths.Add(@"C:\Anaconda\Lib");
            paths.Add(@"C:\Anaconda\site-packages");

            try
            {
                //파일을 읽지 않고 스크립트를 바로작성
                var source = engine.CreateScriptSourceFromFile("KWGuideRE.py");
                source.Execute(scope);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
