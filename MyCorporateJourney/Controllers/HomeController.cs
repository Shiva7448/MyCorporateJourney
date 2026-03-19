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
            //2021
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
                Title = "Received my Laptop",
                Description = "In the morning today, I received a message that my courier is out for delivery. For a moment, I was thinking that I haven’t ordered anything then what is coming. I asked my Maa if she or Papa has ordered anything, she said no and she remind me that it might be my laptop from WIPRO. I checked the shipment number on Delhivery website and it was my laptop. In the afternoon at around 2 PM courier person came and delivered the package. My brother was recording while I was un-boxing the package received. I have received a laptop bag, Mouse, Mouse pad, Acer 14” laptop and a note in my welcome kit. I have connected my laptop to internet and let it install necessary software. It’s an Auto Pilot laptop so I do not need to install anything manually. I have to use it from Monday for training.",
                EventDate = new System.DateTime(2021, 10, 16)
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
            //2022
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
                "Then he said to me that Arvind is Unisure team lead, I was unaware of this till that time. Arvind was trying to add me to a Jira call to introduce me to the rest of the team. Sometimes security training and real-world scenarios collide in the most unexpected ways.",
                EventDate = new System.DateTime(2022, 02, 27)
            });

            events.Add(new JourneyEvent()
            {
                Title = "Working on Holi",
                Description = "It was Holi today, a festival which we used to celebrate it with very much of joy in North India. Typically schools, colleges and offices remain closed for occasion but I was not having holiday today as my base location of work is Bangalore. My brother and my some other friends who had holiday they were teasing me. " +
                "I was not having too much works today except application health checks and meeting to attend. I was on and off whole day, was going to kitchen talking to mother who was making delicious foods, was watching people playing children with colours. For the first time, I felt why elders worry so much about leaves and holidays who works far away from home.",
                EventDate = new System.DateTime(2022, 03, 18)
            });

            events.Add(new JourneyEvent()
            {
                Title = "My first change work",
                Description = "Since I joined Unisure team, I have been responsible for minor investigation incidents and Jira tickets and was working on daily application health check works. In the beginning of this month, I was assigned a change ticket. There is a SQL script which used to run daily in batch and used to send data to business, they had requested to add few more columns in the report. I understood the requirement from Neha and started working on it. With the help of her, I made change in script and tested it in my local environment. " +
                "Previously, I used to think that we need to make change in code and push in repository and the work is completed. But in last few days, I learnt that we need to deploy the changes in non-prod environments, testing there various cases, take approvals from business that non-prod results are correct then only we need to go in Production. I was not even aware that there are separate environments for these stages. The deployment used to happen overnight as there will not be any active user. My first change went in production today and I marked my first contribution to Aviva code repository. ",
                EventDate = new System.DateTime(2022, 05, 22)
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
                Title = "Horrible first callout memory",
                Description = "Last week was very very difficult for me. I was added to callout rotation for the first time and Neha was secondary person. Callout means if there is any issue with application, any batch failure, any unusual alert related to CPU or memory usage then I will be primary point of contact for the whole week either it is mid night or early morning. It is also time of Navratri Puja so I have to do some house works also as my father used to have fast all nine days and my mother used to support him in all other ways, so if there is any outside work I have to manage.",
                SecDescription = "Monday, 26th September was first day, I was about to go to sleep, then got phone call that the Unit price job has been failed. I called Neha and she helped me to resolve it. There were a few job failures that day and next day all resolved without much issue. On Wednesday night, I was involved in my first major incident. During the Vodafone mainframe team’s server upgrade, an issue arose that caused multiple job failures. On Thursday, there was again major issue where almost 30 jobs failed due to connectivity issue doing connect direct to SFG server. I had to wake up early for Puja, had to work during day and in the night, " +
                "I was not able to sleep. I was so tired, then it came Friday night which brought more critical challenge. We had database latch issue and none of the online transactions and batch queries were able to fetch client table. On Saturday early morning, Neha escalated situation to Rajesh and Arvind to look into this issue. We were unable to fix the issue to we had to involve Microsoft support engineer, His was Mr. Tin Tin Tan, belongs to South Korea. We all (Neha, Arvind, Rajesh, Ashok, Pravin and me) were remained on call continuous for more than 24 hours. I was not doing much apart from sending email and taking notes. I was not expecting this busy week while being in on-call support.",
                EventDate = new System.DateTime(2022, 10, 02)
            });

            events.Add(new JourneyEvent()
            {
                Title = "First aniversary in Wipro",
                Description = "I have completed one year in Wipro today. One year passed and it is very supportive and memorable on year in my professional journey. From learning new skills to making friends, the year I will always cherish. It was just a normal day working as usual. But evening brought a surprise and made the day unforgettable, " +
                "I received an email from Pravin. It was related to my confirmatory hike. The email was having an attachment which was describing my salary hike which will be effective from this month. I have received 18% of raise on the current yearly salary. I was very happy. I shared this with all of my family members everyone was very happy. ",
                EventDate = new System.DateTime(2022, 10, 11)
            });

            events.Add(new JourneyEvent()
            {
                Title = "Manager moving out and structural change in team",
                Description = "Since last few weeks, Kiru was telling us that there is going to be ramp down in our team. They chosen Pravin and Shwetha for this it was last day for both of them in this project. It’s been almost a year since I am working under Pravin. He is my first manager in my corporate journey. " +
                "I had heard that managers in office are not so good they use to scold if there is any mistake happen at work. But he was opposite, was so nice to me every time. He helped me always whenever I went to him with my silly questions. It is a bit sad that he is moving out of our team. ",
                SecDescription= "Arvind is our new manager now and he has suggested to make few changes in our team structure. There are four new joiners who joined in last one year including me so he has one mentor to everyone. Each newbie has to report their daily works to their mentors and the mentors will clear their doubts if there is any. My mentor is Neha, Prathyusha’s mentor is Bipul, Nikhil’s mentor is Divya and Geetha’s mentor is Vinod. ",
                EventDate = new System.DateTime(2022, 12, 30)
            });
            //2023
            events.Add(new JourneyEvent()
            {
                Title = "Second client visit",
                Description = "This is my second trip to Bangalore, I came for client visit again and this time I had spent here for two weeks. I took flight from Lucknow this time as it was cheaper than Varanasi and reached here on 5th evening. Nikhil was already present and he had booked a room in PG for both of us. " +
                "Neha, Nikhil and me used to walk to office daily from PG, out PG was nearly 1 KM away from office.  There was a client visit on 8th Feb where some people from Aviva came there were more of business people not technical. We had a town hall with them where they presented their visions for next months and what happened in last one year.",
                SecDescription = "We spent our weekend by exploring the Bangalore. Neha was the planner, Nikhil was guide and I was just happily following them. We went to Kormangala Food Street on Friday evening; there were many restaurants and pubs there. We ate there and came back. On Saturday afternoon, we went to Isha foundation. There is a very big Adiyogi statue, it is build between hills. We took photos there and waited till evening, Laser show was so beautiful to watch. " +
                "We again came back by 12 mid night. On Sunday, we went to ISKCON temple. There was too much crowd in the temple as it was weekend. We took a moment for prayer, spent some peaceful time, and received Prasad. After the temple visit, we stopped by Orion Mall for dinner. Prathyusha also came to Bangalore she had also joined us for that day. Overall, it was a great weekend spent, exploring, eating, and enjoying great company.",
                TerDescription = "On 14th Feb, we had another client visit, this time John Cummings, Ajit Dhaliwal and few other members came. We had many activities with them. John inaugurated new ODC. The new office is in Kodathi location which is around 4 kms away from the current office and situated outskirts of Bangalore. He did floor walk, met with everyone and cut the cake for 21 years of Wipro-Aviva relationship. In the evening, we headed to Radisson Blu hotel, where the clients shared a few speeches, followed by cultural performances from our colleagues, including singing and dancing, then we enjoyed a great food. " +
                "On 15th, 16th and 17th, we worked from old office. Since this ODC is going to be released and no one is coming to office since Covid lockdown. Every desk was having some interesting things, we four (Nikhil, Neha, Prathyusha and I) were checking all drawers and stealing the things which were for our use. These three days were once of most comic days with office guys. We were just laughing entire time on silly things. I enjoyed a lot more than previous client visit. ",
                EventDate = new System.DateTime(2023, 02, 05),
                AltField = "Office party group photo",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = "~/images/3.jpg" },
                    new JourneyEventImage() { Src = "~/images/4.jpg" }
                },
            });

            events.Add(new JourneyEvent()
            {
                Title = "Got scolded for nothing and Arvind helped",
                Description = "Since last few days I was working on a PowerShell script which was requested by business. The script will pick few files from a shared drive, will add some details, will merge them to one file and share the as attachment in email. I had completed the build works and had promoted till Runway region but mainframe change was not ready so " +
                "I asked Neha and Divya that I will try to deploy it in next release as I was on leave between 1st March to 3rd March and they agreed also. Suddenly on 8th March (It was Holi and I was on leave again), Divya called me and said that my changes has been already promoted to production during last weekend.",
                SecDescription = "When I logged in next day I had call with Vineet Rana (a config team member), Divya and Neha. Vineet suggested that the changes were missed by everyone and not to tell anyone and keep news inside as it was our fault but he told Abhishek (his manager) about it and blamed me for everything. Abhishek joined our DSM and he scolded me very badly and asked me to give plan for all other pending works before end of day. I was not able to concentrate on anything and was too much scared for whole Thursday and Friday. " +
                "Arvind was on leave for those two days and he logged in today, I thought he will also scold me but when we had call, he listened every ting, he was too calm and not at all angry on me. I will not forget what he said to me, His words were -> “It is good news that the changes are promoted and business would not need to wait for next release, plan for other pending works and send email to business”. I feel so relaxed after 4 days and am planning to complete the remaining by this Friday.",
                EventDate = new System.DateTime(2023, 03, 13)
            });

            events.Add(new JourneyEvent()
            {
                Title = "My first big development",
                Description = "Since last few months, I was working on two big deployments. There was request from business that they need monthly feed of two different management information about policies so I discussed in Jira call and decided to make stored procedure and add them in batch so that it will run automatically. After deployment when went for gate-keeping to get my changes approved by senior developers, " +
                "then Steven Dibbens rejected my changes and suggested to create new SSIS jobs and deploy them in SQL server. SSIS was a new term for me; I learnt some things from YouTube videos. Neha and Vinod had also similar tickets so Krishna Agnihotri and Arpan Biswas the senior developers gave us three days of KT to develop the package.",
                SecDescription = "After the KT sessions also, I was struggling to get approval from GKs. They (especially Steven) were rejecting my change continuously so I directly went to him and asked for help, he drafted a very long email with different screenshots and explanations and sent it to me which helped me a lot. " +
                "Everybody from this project used to say Steven is not a good person and he never helps but he helped me many time for these changes. Finally both of my SSIS packages are deployed in production today and this is my largest delivery so far in Unisure. I am very proud of me for the efforts I put into completing these tickets.",
                EventDate = new System.DateTime(2023, 09, 09)
            });

            events.Add(new JourneyEvent()
            {
                Title = "News for work from office",
                Description = "I was working as usual today. First half was normal, all meetings got over for today then we received an email from Wipro HR communication. The email states that the offices are opening from 15th November across India. Three days work from office will be mandatory for everyone and all the employees have to report to their base location and my location is Bengaluru. It is also written in the email that those who do not report to the office by 7th Jan 2024 they will face serious consequences. " +
                "I was not ready for this big heart attack. After reading the email, I was not in mood at all to any work. I am worried that how will I survive in Bengaluru; I don’t even know Kannada language; none of my relative or friends are there. I told my mother, she told that one or other day it was going to happen so don’t think more. I also talked to Prince, he said his project is having ODC in Pune so he will be reporting from there. I am also thinking to change my base location. I am literally crying from inside since I read the email. ",
                EventDate = new System.DateTime(2023, 11, 06)
            });

            events.Add(new JourneyEvent()
            {
                Title = "Shifting to Bengaluru",
                Description = "It was my last day as work from home yesterday; I was not at all in mood of moving to Bangalore. I was so sad that I didn’t work anything yesterday. I packed my bags today with all the necessary things. My mother and father were helping me reminding the different things. I was deep sad from inside but was acting normal until it was time to go to leave home. My mother started crying, after seeing her I also started crying. After some time when we get normal, my father drops me to railway station to catch train for Varanasi. ",
                SecDescription = "Prince also came in the morning today (17th Dec) then we took flight to Bangalore and reached there at 4:30 PM. Bipul had already booked PG near to the Wipro office for us which we had decided earlier. I had never met Bipul earlier; I had just seen him on video call in team meetings. I called him when we were about to reach, He was waiting for us near the office. “Bipul was wearing blue baggy lower, white shoes, a black hooded sweat shirt with cap pulled over head & his hands and phone in pant pocket with pink wired earphones in the ear”. This was his first impression to me, one more guy was with him named Roshan Raikar he works in Protection team in Aviva. We came to PG where mine and Bipul’s room number is 205 and Prince’s will be staying in 206.",
                EventDate = new System.DateTime(2023, 12, 16)
            });
            //2024
            events.Add(new JourneyEvent()
            {
                Title = "New year celebration",
                Description = "Last night after dinner at around 11:30 PM, we came to office building and were sitting at 14th floor and waiting for New Year. When the clock hit 12 mid night then firecrackers started burning all around, sound echoing everywhere & Sky was full of lights.",
                SecDescription = "It was holiday today so we planned to go zoo today to celebrate New Year. At around 11 AM today we booked a mini cab for four people (Bipul, Prince, Roshan and me). We reached there by 2 PM and had lunch at a hotel on the way. There was too much crowd at the zoo, we booked the tickets online. We had not enjoyed a lot there because of more crowds and less number of animals there. We came back to PG at dinner time, we have to prepare for work from tomorrow.",
                EventDate = new System.DateTime(2024, 01, 01),
                AltField = "Selfie at Banergatta zoo",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = "~/images/5.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "Mango Mist resort",
                Description = "We had a very enjoyable and wonderful day today. We had gone for team outing with entire Unisure team (32 members) to a resort named ‘Mango Mist’. It was about 25 kilometers from out office. We started our journey at about 8 AM from a bus and reached there by 09:30. After reaching there we had given our wrist band with 10 sports and 1 drink coupon. It was already breakfast time so we had different dishes from buffet. Then we headed towards adventure sports, we did rope climbing, rope-bamboo walk, shooting, human chain football and boating-kayaking. " +
                "I and Bipul were in one kayak and we sailed the boat for about 20 minutes in the pond, it was most exciting activity of the day. At about 2 PM we had our lunch, there were so many verities with both vegetarian and non-vegetarian options. Then we changed our dresses which we had bought last night for the swimming pool, we spent more than 1 hour in the pool, clicked some photos, after that we took bath become fresh and had tea and mock tail drink. We stated our return journey at around six and reached to our PG by 07:30 PM. I am so tired and going to sleep. ",
                EventDate = new System.DateTime(2024, 02, 17),
                AltField = "Group photo at Mango Mist",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src ="~/images/6.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "Going home",
                Description = "I could not go home during Holi so I booked ticket for 6th April to go home for 3 weeks. I have taken few leaves to enjoy at home and I will do work from home for rest of days. I left PG at around 8 Am in the morning saying good bye to PG friends. My flight was at 1 PM which dropped me at Varanasi just before 4 in evening. When I reached at Varanasi airport, very few taxis were there and they were asking very high rate to drop me at railway station. I had no option and took auto rickshaw that I had to pay 500 rupees. I reached home at dinner time. ",
                SecDescription = "It’s 15th April today and I met an accident when me and my brother were going to market by bike. There was a right turn and road was not good, was full of small stones where bike tyre slipped. I got injury on right knee, right elbow and forehead, My brother had also got hurt in his legs. Injury was not much serious, we came back home in same way. I am worried, how will I travel back in this condition to Bengaluru next week. (I returned to Bengaluru on 21st, I was more than half recovered).",
                EventDate = new System.DateTime(2024, 04, 06),
            });

            events.Add(new JourneyEvent()
            {
                Title = "Hangout with office friends",
                Description = "I have survived for around five months in Bengaluru away from my parents and home. For this achievement, I will give all credits to my PG friends. When I first arrived here, I felt out of place and far from happy. But as the days went by, their company helped me settle in unfamiliar city. My PG circle includes - " +
                "Prince (my college friend), Bipul (my roommate & teammate), Anand Pujari (from Quotes team), Subhadeep Chattoraj & Vineet Rana (from Config team), Satya Prakash Pratihary (Digital teammate), Roshan (from Protection team), Vishal Pandey (Prince’s roommate), Nishanth Bhat (from Cherish team) and Vinod from office. Our daily routine is simple and memorable - We go office around 9:00 AM, have lunch together in cafeteria at 1:00 PM, come back after work after 06:30 PM. After dinner, we’d meet up again, go for walk, roaming inside office campus and come back to our room after 11:30 PM. On weekends, we often go to office campus to play Cricket. The time is flying by, and every moment is feeling joyful.",
                EventDate = new System.DateTime(2024, 05, 10),
                AltField = "Group selfie while eating maggie in office",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = "~/images/7.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "NopHelp team invitation",
                Description = "I was late today to go to office was still getting dressed up when Dilli messaged me on teams and requested for a call. Dilli Krishnnaiah is a senior developer; he is lead of NopHelp team. NopHelp is a development team of Unisure which is responsible for providing support/guidance to business team about application, creates new features and make changes in codes if there is any bug to the logics. " +
                "When I reached to office he started a call with Pooja (Our manager manager, She had replaced Arvind as he moved to new team) and Nikhil, uring the call He asked us whether we are interested in working in his team. I wanted to join development team since long so I agreed without any hesitation. Nikhil also agreed to pick NopHelp works.  ",
                SecDescription = "It’s 11th June today and Bipul is joining the team in place of Nikhil. He had a little argument with Dilli on some work where Dilli was chasing him to finish it early. " +
                "Nikhil rejected the invitation and now Bipul will be working with Dilli and me. It was very pleasing for me. Over the coming weeks, we will need to transfer our Unisure Run tasks to other teammates as part of the handover process.",
                EventDate = new System.DateTime(2024, 05, 29)
            });

            events.Add(new JourneyEvent()
            {
                Title = "Late night rate update",
                Description = "A few days ago, I worked till 10:30 PM. I was struggling to find the RCA of one issue where settlement trigger logic was not working properly so was in call with Dilli till that time. It was longest working day since I joined Wipro and Aviva project. I had also worked till 10 PM few times for yearly statement works of SMPI project with Neha. I thought those would be busiest days of my career but today I ended up working until 11:30 PM because of a problem found in the non prod environment during mid yearly rate updates. " +
                "Vinod had handed over this work to me, and before deployment to higher regions we had matched the data. Which initially seems ok but few things missed which lead to this issue. Bipul is currently at home recovering from Dengue he had a few weeks ago, and Vinod is also not in Bengaluru. We three were on call to make the changes, get it approved by senior developers and deploy again as we have very limited time left for Prod deployment. I didn’t have dinner today because of this so have ordered from Swiggy and am waiting for that.",
                EventDate = new System.DateTime(2024, 06, 13)
            });

            events.Add(new JourneyEvent()
            {
                Title = "Nandi hills trip",
                Description = "Since last few weeks, Vinod was asking for a weekend trip but the date was not being decided as one or other person was busy on that weekend. Finally on this weekend we decided to go somewhere. " +
                "Bipul, Nikhil, Vinod and I were the four persons who agreed for the trip. One day prior in the office we had made the whole plan and decided to go for trekking and visiting a temple. Vinod arranged all the snacks, fruits and bread and we went there by Vinod’s car.",
                SecDescription = "We got up at 3AM in the morning become ready and started our journey at about 4AM. Bipul was not hundred percent well as he had not slept properly. We reached at Skandagiri hills at around 6 AM but we were not allowed to enter as only 150 people were allowed to enter at once and there was no slot left. " +
                "Then we went to Nandi hills trekking point and started trekking using the stairs. There were more than two thousand steps and those were not equally aligned. When we had reached at about half of the hill, Bipul was not able to climb more he wanted to take rest; we spend there for an hour. " +
                "Bipul took a nap there and we took photos with clouds and hills on our background, it was having a great view. Then we move forward and reached till the top of the hill. Wind was blowing too fast and there was total cloudy/ foggy, we were hardly able to see till 5 meters. We spend some time there and again took photos, had breakfast from the things we carried and also we ate Idli from a shop. " +
                "The Idli was one of the best I have ever had. It was so spongy like a soft cake and chutney was also good. We came down by 1 PM and went to a temple nearby named Bhoga-Nandeeshwara Temple to spend some time and then while returning back, we stopped by a restaurant where there was a buffet of unlimited food in rupees 350. The food was very delicious, we ate there and then came back to home.",
                EventDate = new System.DateTime(2024, 08, 03),
                AltField = "memories from hill top",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = "~/images/8.jpg" },
                    new JourneyEventImage() { Src = "~/images/9.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "Anxiety of a change deployment",
                Description = "I was in callout this week and also I was working on a change since last few days where frontend users were not getting correct data for some special policies. I had completed build works and got gate keepers approval on 11th August; so along with Dilli and Bipul, I decided to promote this change 25th as next release would be in September last and we cannot hold this Jira ticket for so long time. The very next day when it was approved by gate keepers, I had told in the morning DSM that I am planning to deploy on this date and Bipul will be performing testing in every regions. " +
                "Bipul performed all the test cases within short time and took approvals but when it was going to deploy in Staging region and Neha was told by Divya that she was not aware about this change so Neha got a bit upset on me and said to cancel this release or plan on your risk. We had some calls and convinced them that I am confident about this change and it will not cause any issue so they agreed. Change has been deployed today successfully and there was no issue, all the frontend calls are going fine. I feel very relaxed and conveyed the good news to Neha and Dilli.",
                EventDate = new System.DateTime(2024, 08, 25),
            });

            events.Add(new JourneyEvent()
            {
                Title = "Potluck event",
                Description = "It was Monday, a client holiday and also Krishna Janmashtami today. Since last few days Sai and Nikhil along with other’s team members were planning to have a Potluck event today. They prepared a list of more than 60 people and assigned them what they have to cook and bring for today.",
                SecDescription = "I, Bipul and Anand are living in PG and there is not proper arrangement to cook here so we had to bring chips and snacks. Yesterday, we went to hot chips shop and brought five packets of banana and potato chips. I used to have fast on Janmashtami but due to this occasion my mother suggested to not to do fasting and celebrate the event as birthday of God Krishna. Around 11 AM today some of the volunteers including me went and booked a part of cafeteria in S4 building. " +
                "We decorated all the foods on the serving desks. In the noon everyone came to the floor and had lunch. We enjoyed a lot of varieties of food brought by people. In the evening we went to play Cricket. We played a tri series between Unisure (P&A), Protection and Health teams and we won the final match in a dramatic way. There were 8 runs needed in last over, I got run out then they hit a six on second last ball and took quick single on last ball to win the match.",
                EventDate = new System.DateTime(2024, 08, 26),
                AltField = "group photo after potluck",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = "~/images/10.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "My birthday in Bengaluru",
                Description = "It was my birthday today. Last night I had slept at 10 PM, Prince and Bipul ordered cake and woke me up at midnight. My brother had called me so I talked to him for some time. I cut the cake and celebrated my birthday with my roommates. Then we were not getting sleep so we went for a walk to lakeside. I slept after 02:45 AM and woke up at 6 as I had got call from my mother. I went to office today so later in the afternoon, my teammates brought cake for me and I cut it and celebrated, Neha was on call while I was cutting the cake.",
                SecDescription = "In the evening, Prince, Bipul and me went to our goto restaurant that is Birbal Darbar, we had dinner there which was very delicious. This was all about how I celebrated my first birthday in Bangalore.",
                EventDate = new System.DateTime(2024, 09, 13),
                AltField = "Birthday photo",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = "~/images/11.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "Going back home",
                Description = "Finally, it is the day which we were waiting for so long time. I am going back home today after nearly six months. I, Prince and Bipul had booked ticket for today around two months back and from that day we were just counting the days. I am going home for almost two months so I have already taken permission from Pooja and have planned the leaves for Durga Puja and Diwali. We brought the things which we had to bring home and packed out bags. We put out remaining luggage to one friend’s (Vandana) flat and we vacated the PG to save some money. " +
                "We took cab in the morning at around 10 AM and reached airport, and reached Varanasi in the evening. From there Prince took auto rickshaw to his town and I took train for home. Bipul travelled from different flight to his home town Ranchi. I reached home at mid night; Papa was there to pick me at station and I reached home with him where Maa was waiting for me. I ate dinner at home after so long days.",
                EventDate = new System.DateTime(2024, 09, 26),
                AltField = "Airport selfie",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() { Src = "~/images/12.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "Nikhil's wedding and trip to Hampi",
                Description = "It’s Monday today and we are going to Nikhil’s marriage to his home town. We boarded to train from Bangalore railway station to Koppal. We worked today in office till 6 PM, then came to PG and packed our bags, booked cabs and reached station, had dinner there at a restaurant then took train which was at 10 PM. We will reach there by 8 in the morning.",
                SecDescription = "It’s 10th December, we reached to hotel today, become fresh had breakfast in the hotel which Nikhil had already booked for us. I and some other team members had to login for work as we had not taken leave while few other had taken leave so they were just doing chit chat. During onshore hours when Neha logged in, we all logged off and had played some UNO then we dressed for engagement. Bipul, Kamal and Ashwini danced so much from our team. We took photos, had dinner and came back for rest. ",
                TerDescription = "We woke up at 04:30 in the morning to go to Anjanadari hill and Hampi. We were 10 members who are going, Nikhil had arranged a car for us. Anjanadari is the birthplace of Hanuman Ji which is at hill top; we needed to climb 575+ steps to reach there. After spending some time there we climb down had breakfast there. We were not on leave today also so Kavya was carrying her laptop, she logged in and performed HC of application and serves. We went to visit Vittala temple and ASI ruins, Virupaksha temple, GaviSiddheshwara math etc. Nikhil marriage was early morning so we missed it and only attended the reception ceremony as we came back late from Hampi visit. In the evening, we met Nikhil when he came to hotel and we said bye to him to catch the train to reach Bangalore. ",
                EventDate = new System.DateTime(2024, 12, 09),
                AltField = "Wedding Photo and Hampi group photo",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() {  Src = "~/images/13.jpg" },
                    new JourneyEventImage() {  Src = "~/images/14.jpg" }
                }
            });
            //2025
            events.Add(new JourneyEvent()
            {
                Title = "Vinod's last day in Unisure",
                Description = "It was not a good day for Unisure today. It was last day for Vinod in Aviva, he is being removed by management from the account as part of tenure rotation policy of Wipro. A year ago, Aishwarya faced a similar situation, after more than four years of dedicated work in the team, she was also removed. She had helped me a lot when I joined the team newly. She was very sad on the last day but she had got new project just after few days which were expected as she was very hard working and humble. " +
                "Coming to Vinod, he is one of the person with best sense of humor. He used to sit on the left side of me and Bipul on my right side. We three used to make jokes and giggle whole day. When I heard he will also be leaving the team, I was very sad. I didn’t expect that they will remove him because he was the lone person who takes care of all the mainframe things. They are going to replace him with a new joiner which will be a very silly idea. The good thing is that Vinod has received an offer outside organization, I’m very happy to see him move forward with new opportunities.",
                EventDate = new System.DateTime(2025, 01, 31)
            });

            events.Add(new JourneyEvent()
            {
                Title = "Aviva meet festival 2025",
                Description = "The Aviva festival has been in full swing for the past three months, there were many cultural and sports activities to celebrate. All of us were divided into eight teams like PandA team, Protection team, HealthCare team platforms. Initially, we had participated in desk decoration event where we had secured second place. Our theme for decoration was space-solar system. " +
                "We had created planets from thermocol balls, rocket, satellites, astronaut etc. I had participated in Chess game but had lost in first round. We had Cricket final match yesterday where we defeated Rome team in a close contest. Our team scored 90 runs in 10 overs and we restricted our opponent at 67 of score. Bipul was our captain, Kamal & Venkatesh did good batting and Nethajee & Arjun did good bowling in all matches. We were unbeaten in whole tournament in Cricket. ",
                SecDescription = "We had Badminton event today where I and Nikhil were chosen to represent out team. Out first match was with Assurance team which we won with 21-3 score. Then our semifinal was with Health team which was much intense. The score for semifinal was 21-17, 19-21 and 21-17. I did some mistakes in service and tossed shots which caused loss in second set. " +
                "Our final match was with Protection team where we defeated Biswa ji and Gokul with 21-16 and 21-11 score. I won two sports in two days. Our PandA team sits second after all the events with 200 points and HealthCare team won the Aviva fest tournament.",
                EventDate = new System.DateTime(2025, 02, 13),
                AltField = "Award ceremony photos",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() {  Src = "~/images/15.jpg" },
                    new JourneyEventImage() {  Src = "~/images/16.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "Trip to Bangarapet & WPL in Chinnaswamy",
                Description = "We (Bipul and I) were playing cricket in the office yesterday, Biswa ji (The one in blue Tshirt with thumbs up) asked us about out weekend plans. We didn’t had anything so he invited us with them on a trip. Today We get up early in the morning got ready. " +
                "We were going to Bangarapet, that place is famous for different types of chaats. We took a bus from office gate at 9 O’clock and then caught train and reached there, it was about 80 KMs away from our place. It was too hot today we reached there at 1 PM and walked about 1 KM to reach in the Sun to reach our restaurant. We spent about two hours there and ate different chaats. ",
                SecDescription = "After taking a local train back to Bangalore, we switched to the metro and arrived at Cubbon Park station. Biswa ji had booked tickets for everyone for ongoing WPL match; we reached to Chinnaswamy stadium by 7 PM. There was Cricket match between UP Warriorz and Delhi Capitals. Everyone from our group were supporting Delhi but I and Bipul were supporting UP’s team. We enjoyed match. In the end UP clinched the match, Chinelle Henry scored a quick 50+ score and Grace Harris took four wickets with a hat-trick. " +
                "When we came out of stadium it was around 11 PM so we took cab to reach back to our place. Everyone was hungry so again Biswa ji stepped ahead and ordered food online for everyone. We decided to go in office and have it but many of us were not having our ID cards and it was weekend so guard did agree to give us temporary ID cards. We then went to Biswa ji’s PG and ate there. It was already 2 AM in night when we reached back to our PG. I was exhausted and fell on bed and slept as I had to again wakeup in the morning at 6 for work of technical commissioning of my changes.",
                EventDate = new System.DateTime(2025, 02, 22),
                AltField = "Selfie at Bangarapet",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() {  Src = "~/images/17.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "Disappointment!!!!!",
                Description = "Our appraisal ratings came out today. I received only 4 stars instead of five which I was expecting. I am disappointed with this but I know it will not be going to change whatever I do. In last three months, I have worked and deployed four changes to production without any issue. In those four changes two are related to C sharp code fixes (Switching issue & Bliss screen logic change), one was new a Power Shell script to housekeep the older files from DFS server and one was new SQL related SSIS package. And currently working on one more change and planning to deploy within one month. Despite successfully delivering multiple projects across different technologies, I still didn’t receive full ratings. There is similar case with Bipul, he has also delivered three changes and working on two major changes which will be deployed in few days still he received 4. " +
                "I heard from a colleague that four people from our team got five stars, even though some of them contributed far less than Bipul and me. If we compare with all teams none of the team has delivered more than two changes in last quarter and alone from NopHelp, we three people have promoted eight changes with any production issue. And what did I get for those efforts? a 300-rupee Winner Circle reward, nothing else. One more thing, I have been working in this project sine more than three years, completed all eligibility criteria and still HR told me I’m not even eligible for a promotion. There are some people who are getting promoted without working anything.  One of my friends quote is being true here that ‘looking busy often matters more than actually working hard’. I am really not happy from these things going on in our project.",
                EventDate = new System.DateTime(2025, 06, 17)
            });

            events.Add(new JourneyEvent()
            {
                Title = "Worst day of year and my birthday celebration",
                Description = "It was one of the worst days I experienced in last few years. First incident was that Unisure change team were planning for team outing for 13th Sep, few of our team members were interested to go with them so we had nominated ourselves. Everything was planned and all set for the outing but today after our DSM call, Nowshad (Our L2 manager) declined us to go with the change team. He gave excuse that change team has separate billing and we are not supposed to go with different team member. " +
                "That makes no sense to me as we were going out on a non working day and I was not even in the any type of the weekend activity work rotation. Second incident occurred in the evening, my father was returning to home from Varanasi after attending meeting. A very very bad incident happened with my father which left him, my mother and my whole family shaken and mentally disturbed. I am not going to mention incident as I wish to leave it behind and forget it forever. ",
                SecDescription = "Among everything, one good thing did happen, It was my birthday on 13th so Bipul, Roshan, Tanu and Pranitha had planned celebration for me, where they had booked a restaurant for me and I celebrated birthday and cut the cake there. I didn’t fully enjoy the moment because my mind was at home recalling the incident with my father. But I truly appreciate their efforts which made me feel a bit relaxed from the whole day chaos. ",
                EventDate = new System.DateTime(2025, 09, 12)
            });

            events.Add(new JourneyEvent()
            {
                Title = "Back to Bengaluru and secret santa celebration",
                Description = "According to Wipro’s policy, employees are permitted to work from home for 30 days in a year. While most of my team members utilized this allowance in small portions, I planned strategically by combining leave days with the WFH option and extended the 30 days into more than two and a half months of working from home. I went home on 24th September and returned to Bengaluru today. I took leaves during Durga puja, Diwali and Chhath puja and applied the WFH 3 days per week on the other weeks. " +
                "During last few months while being at home, I met almost all of my family and relatives. I attended many marriages during this period. I also went to marriage of one of my friend Neeraj and met many of college friends after couple of years. I enjoyed very well while being away from home. I still had 4 WFHs left but Bipul and Neha forced me to come back. Bipul also travelled home with me but he came back on 24th Nov so he wanted me to come back as well. Neha recently came back from England and working from Bengaluru so she was also encouraging me to return to office.",
                SecDescription = "It’s 15th Dec today and Wipro has changed it’s policy and reduced the work from home to just 12 days. I have to plan very wisely this time.",
                TerDescription = "Neha and other teammates were planning secret Santa fun activity on occasion of Charismas festival. Everyone had to pick a paper from bowl which will be having a name and we have to give gift to the person whose name will be in the paper. I was at home so Neha picked paper on my behalf and I got Bipul’s name When Bipul asked me whom I have to give gift, I lied and told him random name. " +
                "I bought a full sleeve T-shirt for him. Neha also played game with me, she messaged me two days back with an Amazon link of Neckband and asking if that is good gift for Nikhil. I found today that that gift was for me. Bipul had been part of it from the start; I thought that I am lying to him but he was also playing same game to me. ",
                EventDate = new System.DateTime(2025, 12, 10),
                AltField = "",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() {  Src = "~/images/18.jpg" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "Trip to Mysuru",
                Description = "Holiday season is going on and I was trying to convince Prince, Bipul and other friends who are in Bengaluru for a trip. Prince was instantly on board, but convincing Bipul took quite a bit of effort. I suggested them Mysore which is nearly 150 KMs from our place. I booked train for four people, but one friend got some work to do so he cancelled at last moment. " +
                "Three of us went to the trip. We boarded Shatabdi express train from KSR railway station and reached there at 1 PM. We walked more than half an hour in search of hotel to stay and choosen one which was overpriced. The hotel management provided us Bus travel to visit all the tourist places in charge of 500 rupees per person. ",
                SecDescription = "In the evening we went to Mysore palace, It was extremely crowded, looked like everyone came for vacation. We spent some time there and came out for the bus to go for next place. We travelled an hour in the bus and reached a place named Vrindavan park. That park was having many water fountains of different style and was situated near Kaveri river dam. We came back home about 11 PM. One funny thing happened with us today, " +
                "Bipul wanted to buy feet Sandal for his mother and when we asked auto driver, he took us to a shop. The shop was for sandal wood things and we had to spend there about 4 thousand. On 27th morning, we got ready by 8:30 and had breakfast and went to Art museum, then visited Chanmundeshwari temple on hill top and sand museum. In the evening at 4:00 we had train back to Bengaluru. We had reserved seats but train was so crowded that even we were not able to sit properly on our seats. ",
                EventDate = new System.DateTime(2025, 12, 26),
                AltField = "",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() {  Src = "~/images/19.jpg" }
                }
            });
            //2026
            events.Add(new JourneyEvent()
            {
                Title = "",
                Description = "",
                SecDescription = "",
                TerDescription = "",
                EventDate = new System.DateTime(2024, 10, 11),
                AltField = "",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() {  Src = "~/images/1.jpg" }
                },
                Actions = new List<JourneyEventAction>() {
                    new JourneyEventAction() { Text = "", Url="" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "",
                Description = "",
                SecDescription = "",
                TerDescription = "",
                EventDate = new System.DateTime(2024, 10, 11),
                AltField = "",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() {  Src = "~/images/1.jpg" }
                },
                Actions = new List<JourneyEventAction>() {
                    new JourneyEventAction() { Text = "", Url="" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "",
                Description = "",
                SecDescription = "",
                TerDescription = "",
                EventDate = new System.DateTime(2024, 10, 11),
                AltField = "",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() {  Src = "~/images/1.jpg" }
                },
                Actions = new List<JourneyEventAction>() {
                    new JourneyEventAction() { Text = "", Url="" }
                }
            });

            events.Add(new JourneyEvent()
            {
                Title = "",
                Description = "",
                SecDescription = "",
                TerDescription = "",
                EventDate = new System.DateTime(2024, 10, 11),
                AltField = "",
                Images = new List<JourneyEventImage>() {
                    new JourneyEventImage() {  Src = "~/images/1.jpg" }
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
