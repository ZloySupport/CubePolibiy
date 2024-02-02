using System.Security.Cryptography;
using Shiferina;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ru()
        {
            string TestText = "В результате каждой букве соответствует пара чисел, и шифрованное сообщение превращается в последовательность пар чисел. Расшифровывается путем нахождения буквы стоящей на пересечении строки и столбца.Суть в том, что каждой букве предназначена своя пара цифр одна по горизонтальной линии, а другая по вертикальной.  Данный вид кодирования изначально применялся для греческого алфавита, но затем был распространен на другие языки.";
            string ChangedText = TestText;
            string[] str = new string[2];
            Crypto crypto = new Crypto();
            str = crypto.Encrypt(ChangedText);
            ChangedText = str[0];
            string key = str[1];
            string res = crypto.Decrypt(ChangedText, key);
            Assert.AreEqual(TestText, res);
        }
        [TestMethod]
        public void Eng() {
            string TestText = "As a result, each letter corresponds to a pair of numbers, and the encrypted message turns into a sequence of pairs of numbers. It is decrypted by finding the letter standing at the intersection of a row and a column. The bottom line is that each letter has its own pair of digits, one along a horizontal line and the other along a vertical one.  This type of encoding was originally used for the Greek alphabet, but then it was extended to other languages.";
            string ChangedText = TestText;
            string[] str = new string[2];
            Crypto crypto = new Crypto();
            str = crypto.Encrypt(ChangedText);
            ChangedText = str[0];
            string key = str[1];
            string res = crypto.Decrypt(ChangedText, key);
            Assert.AreEqual(TestText, res);
        }
        [TestMethod]
        public void Spec()
        {
            string TestText = " ?/,.-+=!@(){}";
            string ChangedText = TestText;
            string[] str = new string[2];
            Crypto crypto = new Crypto();
            str = crypto.Encrypt(ChangedText);
            ChangedText = str[0];
            string key = str[1];
            string res = crypto.Decrypt(ChangedText, key);
            Assert.AreEqual(TestText, res);
        }
        [TestMethod]
        public void DataCreate()
        {

            Random rand = new Random();
            string User = Convert.ToString(rand.Next(789,985000));
            User += "HeadlessUser";
            string password = Convert.ToString(rand.Next(999, 999999));
            DB dB = new DB();
            dB.ConnectDB("C:\\Games\\Data.db");
            bool yep = dB.RegisterUser(User, password);
            dB.DisDB();
            Assert.IsTrue( yep);
            

        }
        [TestMethod]
        public void DataAut() {
            string userpass = "adm";
            DB dB = new DB();
            dB.ConnectDB("C:\\Games\\Data.db");
            bool yep = dB.AutUser(userpass, userpass);
            dB.DisDB();
            string user = "adm2";
            dB.ConnectDB("C:\\Games\\Data.db");
            bool yep2 = dB.AutUser(user, "324");
            
            Assert.AreNotEqual(yep,yep2);
        }
        //[TestMethod]
        //public void TryAut() {
        //    string user = "adm2";
        //    DB dB = new DB();
        //    bool yep = dB.AutUser(user, "");
        //    Assert.IsFalse( yep);
        //}
    }
}