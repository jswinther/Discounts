﻿using DiscountsConsole.Data;
using DiscountsConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountsConsole.DAL
{
    public class SellerDAL : AbstractDAL<Seller>
    {
        public SellerDAL(List<Seller> list) : base(list)
        {
        }
    }
}
