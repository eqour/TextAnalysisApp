using NUnit.Framework;
using System;
using System.IO;
using TextAnalysisApp.Utils;

namespace TextAnalysisAppTest
{
    internal class TextFileReaderTests
    {
        private const string TEMP_FILENAME = "temp.txt";

        [Test]
        public void CorrectUTF8FileTest()
        {
            string expected = "Танграм - головоломка, состоящая из семи плоских фигур, которые складывают определённым образом для получения другой, более сложной фигуры.";
            RunWithFile(
                path => File.WriteAllText(path, expected),
                path =>
                {
                    string actual = TextFileReader.ReadFile(path);
                    Assert.AreEqual(expected, actual);
                });
        }

        [Test]
        public void NotFoundFileTest()
        {
            RunWithFile(
                path => { },
                path =>
                {
                    try
                    {
                        string actual = TextFileReader.ReadFile(path);
                        Assert.Fail();
                    }
                    catch (FileNotFoundException)
                    { }
                });
        }

        private void RunWithFile(Action<string> createFileAction, Action<string> testRunner)
        {
            createFileAction(TEMP_FILENAME);
            try
            {
                testRunner(TEMP_FILENAME);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
            finally
            {
                if (File.Exists(TEMP_FILENAME))
                {
                    File.Delete(TEMP_FILENAME);
                }
            }
        }
    }
}
