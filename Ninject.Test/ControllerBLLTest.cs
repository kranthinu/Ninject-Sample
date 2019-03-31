using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject.BLL;
using Moq;
using Ninject.DAL;

namespace Ninject.Test
{
    [TestClass]
    public class ControllerBLLTest
    {
        private Mock<ISqlBLL> mockSqlBLL;
        private Mock<IMailSenderBLL> mockMailSenderBLL;

        ControllerBLL controllerBLL;

        [TestInitialize]
        public void init()
        {
            mockSqlBLL = new Mock<ISqlBLL>();
            mockMailSenderBLL = new Mock<IMailSenderBLL>();

            controllerBLL = new ControllerBLL(mockSqlBLL.Object, mockMailSenderBLL.Object);
        }

        [TestMethod]
        public void process_Success()
        {
            try
            {
                mockSqlBLL.Setup(x => x.getEmail(1)).Returns("Alan.Donald@gmail.com");

                controllerBLL.process(1);

                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void process_Error()
        {
            try
            {
                mockSqlBLL.Setup(x => x.getEmail(6)).Returns("");

                controllerBLL.process(6);

                Assert.Fail();
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}
