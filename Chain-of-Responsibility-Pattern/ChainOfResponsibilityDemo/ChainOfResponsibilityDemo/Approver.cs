﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    public abstract class Approver
    {
        protected Approver successor;

        public void SetSuccessor(Approver successor) {
            this.successor = successor;
        }
        public abstract void ProcessRequest(Purchase purchase);
    }
}
