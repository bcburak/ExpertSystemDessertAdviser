﻿using chen0040.ExpertSystem;
using ExpertSystemDessertAdviser.Context;
using ExpertSystemDessertAdviser.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rule = chen0040.ExpertSystem.Rule;

namespace ExpertSystemDessertAdviser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			Form1 frm = new Form1();
			frm.Hide();
			AdviserForm adviserForm = new AdviserForm();
			adviserForm.Show();
			var asd = getInferenceEngine();

        }

        private Customer GetUsers()
        {
            MainDbContext db = new MainDbContext();

            return db.Customers.FirstOrDefault();
            //foreach (var item in db.User)
            //{
            //    item.
            //}
        }

		public RuleInferenceEngine getInferenceEngine()
		{
			RuleInferenceEngine rie = new RuleInferenceEngine();

			Rule rule = new Rule("Bicycle");
			rule.AddAntecedent(new IsClause("vehicleType", "cycle"));
			rule.AddAntecedent(new IsClause("num_wheels", "2"));
			rule.AddAntecedent(new IsClause("motor", "no"));
			rule.setConsequent(new IsClause("vehicle", "Bicycle"));
			rie.AddRule(rule);

			rule = new Rule("Tricycle");
			rule.AddAntecedent(new IsClause("vehicleType", "cycle"));
			rule.AddAntecedent(new IsClause("num_wheels", "3"));
			rule.AddAntecedent(new IsClause("motor", "no"));
			rule.setConsequent(new IsClause("vehicle", "Tricycle"));
			rie.AddRule(rule);

			rule = new Rule("Motorcycle");
			rule.AddAntecedent(new IsClause("vehicleType", "cycle"));
			rule.AddAntecedent(new IsClause("num_wheels", "2"));
			rule.AddAntecedent(new IsClause("motor", "yes"));
			rule.setConsequent(new IsClause("vehicle", "Motorcycle"));
			rie.AddRule(rule);

			rule = new Rule("SportsCar");
			rule.AddAntecedent(new IsClause("vehicleType", "automobile"));
			rule.AddAntecedent(new IsClause("size", "medium"));
			rule.AddAntecedent(new IsClause("num_doors", "2"));
			rule.setConsequent(new IsClause("vehicle", "Sports_Car"));
			rie.AddRule(rule);

			rule = new Rule("Sedan");
			rule.AddAntecedent(new IsClause("vehicleType", "automobile"));
			rule.AddAntecedent(new IsClause("size", "medium"));
			rule.AddAntecedent(new IsClause("num_doors", "4"));
			rule.setConsequent(new IsClause("vehicle", "Sedan"));
			rie.AddRule(rule);

			rule = new Rule("MiniVan");
			rule.AddAntecedent(new IsClause("vehicleType", "automobile"));
			rule.AddAntecedent(new IsClause("size", "medium"));
			rule.AddAntecedent(new IsClause("num_doors", "3"));
			rule.setConsequent(new IsClause("vehicle", "MiniVan"));
			rie.AddRule(rule);

			rule = new Rule("SUV");
			rule.AddAntecedent(new IsClause("vehicleType", "automobile"));
			rule.AddAntecedent(new IsClause("size", "large"));
			rule.AddAntecedent(new IsClause("num_doors", "4"));
			rule.setConsequent(new IsClause("vehicle", "SUV"));
			rie.AddRule(rule);

			rule = new Rule("Cycle");
			rule.AddAntecedent(new LessClause("num_wheels", "4"));
			rule.setConsequent(new IsClause("vehicleType", "cycle"));
			rie.AddRule(rule);

			rule = new Rule("Automobile");
			rule.AddAntecedent(new IsClause("num_wheels", "4"));
			rule.AddAntecedent(new IsClause("motor", "yes"));
			rule.setConsequent(new IsClause("vehicleType", "automobile"));
			rie.AddRule(rule);

			return rie;
		}


	}
}
