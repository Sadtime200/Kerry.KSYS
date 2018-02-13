using System;
using Kerry.KSYS.Scheduler.Test.ServiceReference1;
using Kerry.KSYS.Scheduler.Test.ServiceReference2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kerry.KSYS.Scheduler.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new JOBOperationClient();
            try
            {
                client.RemoveCONSOLUNID();
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                client.Close();
            }


        }

        [TestMethod]
        public void TestMethod2()
        {
            var client = new JOBOperationClient();
            try
            {
                client.UpdateCONSOLUNID();
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                client.Close();
            }


        }
        [TestMethod]
        public void TestMethod4()
        {
            var client = new JOBOperationClient();
            try
            {
                client.AddCONSOLUNID();
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                client.Close();
            }


        }


        [TestMethod]
        public void TestMethod3()
        {
            var client = new JOBLINKsOperationClient();
            try
            {
                client.Supplyment();
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                client.Close();
            }


        }
    }
}
