using Microsoft.AspNetCore.Mvc;
using MyCorporateJourney.Models;
using System.Diagnostics;

namespace MyCorporateJourney.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<JourneyEvent> events = new List<JourneyEvent>();

            events.Add(new JourneyEvent()
            {
                Title = "Barcelona \u0026 Tenerife",
                Subtitle = "May 25, 2023",
                Description = "Barcelona is an excellent place to discover world-class arts and culture. Bullfighting was officially banned several years ago, but the city remains rich with festivals and events. The sights in Barcelona are second to none. Don’t miss the architectural wonder, Casa Mila—otherwise known as La Pedrera. It’s a modernist apartment building that looks like something out of an expressionist painting. Make your way up to the roof for more architectural surprises. And if you like Casa Mila, you’ll want to see another one of Antoni Gaudi’s architectural masterpieces, Casa Batllo, which is located at the center of Barcelona.\r\nTenerife, one of the nearby Canary Islands, is the perfect escape once you’ve had your fill of the city. In Los Gigantes, life revolves around the marina.",
                EventDate = new System.DateTime(2023, 5, 25),
                AltField = "Arc de Triomf, Barcelona, Spain",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = "https://demos.telerik.com/aspnet-mvc/tripxpert/Images/Gallery/Barcelona-and-Tenerife/Arc-de-Triomf,-Barcelona,-Spain_Liliya-Karakoleva.JPG?width=500&amp;height=500" }
                },
                Actions = new List<JourneyEventAction>() {
                    new JourneyEventAction() { Text = "More info about Barcelona", Url="https://en.wikipedia.org/wiki/Barcelona" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "Onboarding in WIPRO",
                Description = "Today is the day when I got call from Wipro that my joining date will be 11th October they had scheduled a meeting for today where they on boarded me along with other around two hundred new joiners. They asked us to fill some forms on Wipro’s iCIMS on-boarding portal and I had to provide my home address also to get welcome kit to start working. Few days back, they had given me some modules (PJP modules) and assignments on C# dot net technology to read and understand before the training starts. " +
                "\r\n\tIn the evening today after on boarding completed, they had emailed me with my employee number that is ‘20282569’, my credentials and my email id (shivam.singh28@wipro.com). \r\n",
                EventDate = new System.DateTime(2021, 10, 05),
                Actions = new List<JourneyEventAction>() {
                    new JourneyEventAction() { Text = "More info about Wipro", Url="wikipedia.com" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "My first step in corporate",
                Description = "It was my first day at Wipro as an employee. I was super excited to know more about Wipro and how a corporate life works. Due to COVID19 protocols, the offices are still not opened so our training will be online. There are 163 employees in my batch who will be getting trained with me. In the morning meeting P. B. Kotur sir and Anandhakrishnan Devraj sir welcomed us warmly. They presented us some slides about their journey, background of WIPRO Company and also showed us calendar for our induction program and trainings. " +
                "First three days are for induction program where we will get to know more about WIPRO, virtual seminar with Rishad Premji and other higher management, how to setup our laptops and use virtual machine etc. I have not received my laptop yet, it is still on the way to my home. Our final training for dot net is going to start from 18th October till 13th November post that I have to clear the training exam in four attempts, first exam is on 15th November; I need to study hard for it. ",
                EventDate = new System.DateTime(2021, 10, 11)
            });

            events.Add(new JourneyEvent()
            {
                Title = "My first salary",
                Description = "It was last working day of October month so it was salary day. I got my first salary from WIPRO today. I received salary for the 20 days, I spent here in training. I got a total of 17,400 rupees only. When I get notification from bank, I showed it to my parents, everyone was very happy. " +
                "I asked both my mother and father that what they want from my first salary, both of them said that they didn’t want anything. They suggested me to keep money with me and asked me to buy whatever I want to buy for myself. I will never forget this day; it will always be one of the best days of my life.",
                EventDate = new System.DateTime(2021, 10, 29)
            });

            events.Add(new JourneyEvent()
            {
                Title = "PRP exam after training",
                Description = "Since last four weeks, we were being trained for C# programming and Dot net framework. There was exam today for it which was online on mettle software. We needed at least 60 percentages to pass the exam. " +
                "There were two programming questions and 20 multiple choice questions. I started exam at 12 PM in the noon and it was for two hours. I attempted all questions. When I submitted the exam, the result came out. I received 86% in the exam and I have passed it. Now my training is over and I will be assigned a project to start work.",
                EventDate = new System.DateTime(2021, 11, 16)
            });

            events.Add(new JourneyEvent()
            {
                Title = "My first project in Wipro",
                Description = "I had received an email few days back that I have been allocated to a project. I received a phone call from Abhishek Basetti yesterday, he asked me few questions those were technical and behavioral both. He also said that my KT will start from today. The project name is ‘AVIVA’. Aviva is a UK based insurance company which is having branches across the world (I googled it). " +
                "The team I am assigned is a cloud platform of Healthcare team where they are requested to upgrade the version of Terraform for their code. There was a two hours KT (knowledge transfer) session scheduled today where they teach me few unfamiliar names like Terraform, Puppet, Jira, Assyst etc. I am searching these terms on Google to learn more about it, these things are looking interesting to me.",
                EventDate = new System.DateTime(2022, 01, 28)
            });

            events.Add(new JourneyEvent()
            {
                Title = "My introduction to Unisure",
                Description = "I got a call from one of my manager Vishwanath Sista and manager Pravin Patil yesterday. They told me that as I have been trained in dot net technology and this cloud work is not matching my profile. So they decided to move me in different team. My new team is named “Unisure” and Pravin is manager of this team. " +
                "It is a backend application which is holding around 30 Lakh pension policies. I have to work here on C# codes, SQL queries, Mainframe and AWS services. Pravin had introduced me with two teammates- Vinod Kumar and Ashwani Shekhar. Vinod is going to help me in sorting all of my access required for daily works. Ashwani is going to move out of company so he will be giving me KT of works. ",
                EventDate = new System.DateTime(2022, 02, 10)
            });

            events.Add(new JourneyEvent()
            {
                Title = "Team introduction and KTs",
                Description = "It’s been two weeks since I am working in this team. I have been in contact of some of people. There is one more new joiner who has joined along with me. Her name is Prathyusha Gurijala and she is from Telangana is also from Electronics engineering background. Vinod is helping us in performing daily health checks of application and other KTs, he is having more than five years of experience and is expert in mainframe. I used to call him and everyone in the team Sir or Ma’am but he make me understand that in corporate world we used to address everyone by name. " +
                "I have known some few peoples from Unisure team. My team members are “Prathyusha Gurijala, Vinod Kumar, Neha Lidbe, Yadavalli Aishwarya, Bipul Mishra, Divya L, Dudipalla Tejashwini, Swetha Maradi and Ashok Chenchula”. Everyone is helpful and am getting a little bit help in one or other things from them to know more about daily works. There are two more people who are working from client location Arvindkumar Murugan and Rajesh Manohar. Arvind is the lead of our team and Rajesh is Database administrator.",
                SecDescription = "A few days ago, something funny happened while I was online. I received a Teams call from an external ID, and in our training we were told to not interact with people outside the organization due to phishing attack risks. I declined the call and I cut it three times just to be safe. I asked Pravin whether I should report this incident. " +
                "Then he said to me that Arvind is Unisure team lead, I was unaware of this till that time. Arvind was trying to add me to a Jira call to introduce me to the rest of the team. Sometimes security training and real-world scenarios collide in the most unexpected ways",
                EventDate = new System.DateTime(2022, 02, 27)
            });

            events.Add(new JourneyEvent()
            {
                Title = "First trip to Bengaluru",
                Description = "Since last few weeks, Kiru was telling us every day that there will be client visit on 24th and 25th August and everyone has to be in Bengaluru office for both days. Client visit means some management people from Aviva will be visiting our office for some important announcements and meetings. I booked flight ticket on 21st from Varanasi to go Bangalore. I will be staying there for a week." +
                "It was my first flight journey. My brother came with me till airport, my flight take off time was around 2 PM and drop off was 04:30 PM. Bangalore airport is around 50 KMs far from the city, had to take cab to reach Kaikondrahalli, where my office is. I reached there at about 6 PM and took a PG to live for one week.",
                SecDescription = "On Monday, 22nd I dressed up and reached office by 09:30 and reached office, But I was not having access to ODC (place in office where we need to sit and work) so was sitting in cafeteria and waiting for others. There was a funny incident happened, Divya was also sitting in the cafeteria on the other side, we were there for around half an hour but we didn’t recognize each other as we had not seen each other any time. " +
                "When Neha, Prathyusha and others came then we got to know each other and we laughed so hard for long. I met everyone for the first time with whom I was working from more than six month. On Wednesday, we had client visit. We had to go in conference room where we met John Cummings (he is group CIO of Aviva). He also came inside ODC, met with everyone with very high energy. ",
                TerDescription = "We had team lunch at office where Saurabh (One of Scrum master) ordered pizza for everyone and also we went to team dinner on Thursday night to a restaurant named Street 1522. We stayed there for more than four hours, we did so much talks not related to work and enjoyed a lot. " +
                "I have return flight today to my home town, I am writing this while sitting on airport. Now I got to know how people works in office, how office looks like. My experience is very very good to meet colleagues, seniors and managers but I feel work from home is better. ",
                EventDate = new System.DateTime(2022, 08, 21),
                AltField = "Unisure team group photo",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = "~/images/1.jpg" },
                    new JourneyEventImage() { Src = "~/images/2.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "",
                Description = "",
                EventDate = new System.DateTime(2021, 10, 11),
                AltField = "",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = ";height=500" }
                },
                Actions = new List<JourneyEventAction>() {
                    new JourneyEventAction() { Text = "", Url="" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "",
                Description = "",
                EventDate = new System.DateTime(2021, 10, 11),
                AltField = "",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = ";height=500" }
                },
                Actions = new List<JourneyEventAction>() {
                    new JourneyEventAction() { Text = "", Url="" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "",
                Description = "",
                EventDate = new System.DateTime(2021, 10, 11),
                AltField = "",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = ";height=500" }
                },
                Actions = new List<JourneyEventAction>() {
                    new JourneyEventAction() { Text = "", Url="" }
                }
            });

            return View(events);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
