﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EliteTravels.Models;
using Microsoft.AspNetCore.Mvc;
using TextFile = System.IO;

namespace EliteTravels.Controllers
{
    public class PracticeController : Controller
    {
        List<QuestionAndAnswers> originalQandAns = new List<QuestionAndAnswers>();
        public PracticeController()
        {
            LoadQuestionsFromFile();
        }

        private void LoadQuestionsFromFile()
        {
            string[] lines = TextFile.File.ReadAllLines(@"C:\Users\vinod\OneDrive\Desktop\HtmlExamples\Elite2\InterviewQuetions.txt");
            foreach (string ln in lines)
            {
                QuestionAndAnswers qa = new QuestionAndAnswers();

                string[] values = ln.Split("?");
                qa.Question = values[0];
                string[] options = values[1].Split(",");

                List<string> listOpt = new List<string>();
                foreach (string eachOp in options)
                {
                    listOpt.Add(eachOp);
                };

                qa.Options = listOpt;
                qa.Answer = values[2];

                originalQandAns.Add(qa);
            }
        }

        public IActionResult Index()
        {
            AssigmentResult assigmentResult = new AssigmentResult();
            List<Assignment> test = new List<Assignment>();

            originalQandAns.ForEach(q =>
            {
                Assignment assignment = new Assignment();
                assignment.Question = q.Question;

                assignment.Options = q.Options;
                test.Add(assignment);
            });
            assigmentResult.Exam = test;

            return View("Exam", assigmentResult);
        }

        [HttpPost]
        public ActionResult Index(AssigmentResult examResult)
        {
            examResult.Exam.ForEach(q => {

            });
            return View("Exam", examResult);
        }
    }
}