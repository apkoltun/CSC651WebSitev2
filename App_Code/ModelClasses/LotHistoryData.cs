﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class ST_Lot_History_Data
    {
        public string Lot_Number { get; set; }
        public int Months_Recorded { get; set; }
        public string Month { get; set; }
        public Nullable<int> Num_eggs_on_hand { get; set; }
        public Nullable<decimal> Eggs_on_hand_weight { get; set; }
        public Nullable<decimal> Fish_per_pound { get; set; }
        public Nullable<int> Num_Mortalities { get; set; }
        public Nullable<int> Inv_adj_num { get; set; }
        public Nullable<int> Eggs_spawned_num { get; set; }
        public Nullable<int> Eggs_pick_off_num { get; set; }
        public Nullable<decimal> Eye_up_hatch { get; set; }
        public Nullable<int> Num_eggs_trans_in { get; set; }
        public Nullable<decimal> Eggs_trans_in_weight { get; set; }
        public Nullable<decimal> Num_eggs_trans_out { get; set; }
        public Nullable<decimal> Eggs_trans_out_weight { get; set; }
        public Nullable<int> Fish_stocked_num { get; set; }
        public Nullable<int> Fish_stocked_weight { get; set; }
        public Nullable<decimal> Weight_Gain_per_month { get; set; }
        public Nullable<decimal> Weight_Gain_to_date { get; set; }
        public string Feed_Type_A { get; set; }
        public string Feed_Type_B { get; set; }
        public Nullable<decimal> Amount_Fed_A { get; set; }
        public Nullable<decimal> Amount_Fed_B { get; set; }
        public Nullable<decimal> Unit_Price_Fed_A { get; set; }
        public Nullable<decimal> Unit_Price_Fed_B { get; set; }
        public Nullable<decimal> Food_fed_per_month { get; set; }
        public Nullable<decimal> Food_fed_to_date { get; set; }
        public Nullable<decimal> Feed_cost_per_month { get; set; }
        public Nullable<decimal> Feed_cost_to_date { get; set; }
        public Nullable<decimal> Conversion_rate_per_month { get; set; }
        public Nullable<decimal> Conversion_rate_to_date { get; set; }
        public Nullable<decimal> Length_on_last_day_of_month { get; set; }
        public Nullable<decimal> Inc_in_length_during_month { get; set; }
        public Nullable<int> Num_of_days_feed_per_month { get; set; }
        public Nullable<int> Num_of_days_feed_cum { get; set; }
        public Nullable<decimal> Ave_daily_inc_month { get; set; }
        public Nullable<decimal> Ave_daily_inc_cum { get; set; }
        public Nullable<decimal> Condition_factor { get; set; }
        public string Comments { get; set; }
    }
}