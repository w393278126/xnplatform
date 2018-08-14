﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xn.Platform.Core.Data;

namespace Plu.Platform.Domain.Order
{
    [Table("t_order_orderplane")]
    public class OrderPlaneModel
    {
        /// <summary>
        /// id
        /// </summary>		

        public string id { get; set; }
        /// <summary>
        /// userID
        /// </summary>		

        public string userID { get; set; }
        /// <summary>
        /// orderID
        /// </summary>		

        public string orderID { get; set; }
        /// <summary>
        /// states
        /// </summary>		

        public int states { get; set; }
        /// <summary>
        /// startAddr
        /// </summary>		

        public string startAddr { get; set; }
        /// <summary>
        /// startAirport
        /// </summary>		

        public string startAirport { get; set; }
        /// <summary>
        /// on update CURRENT_TIMESTAMP
        /// </summary>		

        public DateTime startDate { get; set; }
        /// <summary>
        /// destAddr
        /// </summary>		

        public string destAddr { get; set; }
        /// <summary>
        /// destAirport
        /// </summary>		

        public string destAirport { get; set; }
        /// <summary>
        /// on update CURRENT_TIMESTAMP
        /// </summary>		

        public DateTime destDate { get; set; }
        /// <summary>
        /// custName
        /// </summary>		

        public string custName { get; set; }
        /// <summary>
        /// idCardNo
        /// </summary>		

        public string idCardNo { get; set; }
        /// <summary>
        /// personType
        /// </summary>		

        public int personType { get; set; }
        /// <summary>
        /// airways
        /// </summary>		

        public string airways { get; set; }
        /// <summary>
        /// airwaysIcon
        /// </summary>		

        public string airwaysIcon { get; set; }
        /// <summary>
        /// flightNumber
        /// </summary>		

        public string flightNumber { get; set; }
        /// <summary>
        /// roomType
        /// </summary>		

        public int roomType { get; set; }
        /// <summary>
        /// price
        /// </summary>		

        public decimal price { get; set; }
        /// <summary>
        /// salePrice
        /// </summary>		

        public decimal salePrice { get; set; }
        /// <summary>
        /// cancelReason
        /// </summary>		

        public string cancelReason { get; set; }
        /// <summary>
        /// returnFee
        /// </summary>		

        public decimal returnFee { get; set; }
        /// <summary>
        /// returnTotal
        /// </summary>		

        public decimal returnTotal { get; set; }
        /// <summary>
        /// channelID
        /// </summary>		

        public string channelID { get; set; }
        /// <summary>
        /// noticeId
        /// </summary>		

        public string noticeId { get; set; }
        /// <summary>
        /// on update CURRENT_TIMESTAMP
        /// </summary>		

        public DateTime addDate { get; set; }
        /// <summary>
        /// costPrice
        /// </summary>		

        public decimal costPrice { get; set; }
        /// <summary>
        /// desAirCode
        /// </summary>		

        public string desAirCode { get; set; }
        /// <summary>
        /// tripNo
        /// </summary>		

        public string tripNo { get; set; }
        /// <summary>
        /// depAirCode
        /// </summary>		

        public string depAirCode { get; set; }
        /// <summary>
        /// psgInfo
        /// </summary>		

        public string psgInfo { get; set; }
        /// <summary>
        /// sellsPrice
        /// </summary>		

        public decimal sellsPrice { get; set; }
    }
}
