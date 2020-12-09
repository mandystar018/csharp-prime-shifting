using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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

    [TestMethod]
    public void NumberCount_DoesCountNumbers_List()
    {
      Prime prime = new Prime();
      prime.NumberCount(5);
      List<int> result = new List<int> {1,2,3,4,5};
      Assert.AreEqual(result, prime.numbers);
    }
  }
}