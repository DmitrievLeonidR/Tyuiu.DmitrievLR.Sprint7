namespace Tyuiu.DmitrievLR.Sprint7.Project.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = "D:\\C_SPRINTS\\repos\\Tyuiu.DmitrievLR.Sprint7\\Tyuiu.DmitrievLR.Sprint7.Project.V9\\bin\\Debug\\net8.0-windows\\Playlist.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;


            Assert.AreEqual(wait, fileExist);
        }
    }
}