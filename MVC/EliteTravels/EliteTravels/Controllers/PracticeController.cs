using EliteTravels.Models;
using EliteTravels.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TextFile = System.IO;

namespace EliteTravels.Controllers
{
    public class PracticeController : Controller
    {
        List<QuestionAndAnswers> originalQandAns = new List<QuestionAndAnswers>();
        List<Assignment> subQandA = new List<Assignment>();
        int maxQuestionsToDisplay = 2;

        public PracticeController()
        {
            LoadQuestionsFromFile();
        }

        private void LoadQuestionsFromFile()
        {
            string[] lines = TextFile.File.ReadAllLines(@"F:\EliteExamples\EliteCareerHubExamples\InterviewQuetions.txt");
            foreach (string ln in lines)
            {
                QuestionAndAnswers qa = new QuestionAndAnswers();

                string[] values = ln.Split("?");
                qa.Question = values[0];
                string[] options = values[1].Split(",");
                qa.Options = options.ToList();
                qa.Answer = values[2];

                originalQandAns.Add(qa);
            }

            foreach (QuestionAndAnswers ln in originalQandAns)
            {
                Assignment qa = new Assignment();
                qa.Question = ln.Question;
                qa.Options = ln.Options;
                qa.Answer = ln.Answer;
                subQandA.Add(qa);
            }
        }

        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Set(Constants.SubmittedQuestions, subQandA);
            int pageNumber = 1;
            decimal totalPages = GetTotalNumberOfPages(originalQandAns.Count);
            AssessmentData examData = GetAssessmentQuestionsByPageNumber(pageNumber, totalPages);
            return View("Exam", examData);
        }

        [HttpPost]
        public ActionResult Index(AssessmentData examResult)
        {
            UpdateSubmittedQandAns(examResult);
            return View("Exam", GetAssessmentQuestionsByPageNumber(examResult.PageNumber, examResult.TotalPages));
        }

        private void UpdateSubmittedQandAns(AssessmentData examResult)
        {
            List<Assignment> submittedQandAns = HttpContext.Session.Get<Assignment>(Constants.SubmittedQuestions);
            examResult.Exam.ForEach(q =>
            {
                Assignment sub = submittedQandAns.Where(origQue => origQue.Question == q.Question).FirstOrDefault();
                sub.SelectedAnswer = q.SelectedAnswer;
            });

            HttpContext.Session.Clear();
            HttpContext.Session.Set(Constants.SubmittedQuestions, submittedQandAns);
        }

        private AssessmentData GetAssessmentQuestionsByPageNumber(int pageNumber, decimal maxPageNumber)
        {
            AssessmentData assigmentResult = new AssessmentData();
            if (pageNumber == maxPageNumber + 1)
            {
                List<Assignment> submittedQandAns = HttpContext.Session.Get<Assignment>(Constants.SubmittedQuestions);
                assigmentResult.Exam = submittedQandAns;
                assigmentResult.ShowResult = true;
                assigmentResult.TotalMarks = originalQandAns.Count;
                foreach (var q in submittedQandAns)
                {
                    if (q.Answer == q.SelectedAnswer)
                        assigmentResult.TotalMarksSecured++;
                }
                return assigmentResult;
            }

            int numberOfQuestionsToSkip = (pageNumber - 1) * maxQuestionsToDisplay;
            List<Assignment> test = new List<Assignment>();

            originalQandAns.Skip(numberOfQuestionsToSkip)
                           .Take(maxQuestionsToDisplay)
                           .ToList()
                           .ForEach(q =>
                                    {
                                        Assignment assignment = new Assignment();
                                        assignment.Question = q.Question;
                                        assignment.Options = q.Options;
                                        test.Add(assignment);
                                    });
            assigmentResult.Exam = test;
            assigmentResult.PageNumber = pageNumber;
            assigmentResult.TotalPages = maxPageNumber;

            return assigmentResult;
        }

        private decimal GetTotalNumberOfPages(int originalQandAnsCount)
        {
            decimal total = originalQandAnsCount / Convert.ToDecimal(maxQuestionsToDisplay);
            return Math.Ceiling(total);
        }
    }
}