using NUnit.Framework;

using System.Collections.Generic;
using Moq;
using Microsoft.AspNetCore.Mvc;
using AuditBenchmarkModule.Models;
using AuditBenchmarkModule.Repository;
using AuditBenchmarkModule.Providers;
using AuditBenchmarkModule.Controllers;

namespace AuditBenchmarkModule.Testing
{
    public class Tests
    {
        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            BenchmarkRepo obj1 = new BenchmarkRepo();

            BenchmarkProvider bp = new BenchmarkProvider(obj1);

            AuditBenchmarkController obj = new AuditBenchmarkController(bp);

            var data = obj.Get() as OkObjectResult;

            Assert.AreEqual(200, data.StatusCode);
        }
    }
}