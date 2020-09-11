using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STASHAPI.Tests
{
    [TestClass()]
    public class STASHAPITests
    {
        [TestMethod()]
        public void EncryptStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void STASHAPITest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void STASHAPITest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getConstantsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void __toStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getVersionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void setSignatureTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getSignatureTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EncryptStringTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void isValidTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SendRequestTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void sendDownloadRequestTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SendFileRequestTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void validateSourceParamsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void validateDestParamsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void validateCredParamsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void validateParamsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DictToStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Http_build_queryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void regexToUpperTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void regexToLowerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Hash_hmacTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Dictionaries_mergeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void genRandomStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void hex2binTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void bin2hexTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void arr2StrTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsValidURLTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getFileTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void putFileTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void copyFileTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void renameFileTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void moveFileTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteFileTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void listFilesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void listFoldersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getFolderIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void createDirectoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void renameDirectoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void moveDirectoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteDirectoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getFileInfoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getFolderInfoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getSyncInfoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void checkCredsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void isValidUserTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetResponseCodeDictTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetErrorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsStringArraysEqualTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsNumericTestTrue()
        {
            bool tVal1 = Stash.StashAPI.IsNumeric("1234");
            bool tVal2 = Stash.StashAPI.IsNumeric("0");
            Assert.IsTrue(tVal1 && tVal2);
        }

        [TestMethod()]
        public void IsNumericTestFalse()
        {
            bool tVal1 = Stash.StashAPI.IsNumeric("ABCD");
            bool tVal2 = Stash.StashAPI.IsNumeric("A1");
            bool tVal3 = Stash.StashAPI.IsNumeric("1A");
            bool tVal4 = Stash.StashAPI.IsNumeric("0.0");
            Assert.IsFalse(tVal1 || tVal2 || tVal3);
        }

    }
}