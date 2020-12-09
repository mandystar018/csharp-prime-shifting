using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sieve.Models;

namespace Sieve.Tests
{
  [TestClass]
  public class PrimeTests
  {  
    [TestMethod]
    public void Prime_WhatItDoes_ExpectedResult()
    {
      Prime newPrime = new Prime();
      Assert.AreEqual(typeof(Prime), newPrime.GetType());
    }
  }
}