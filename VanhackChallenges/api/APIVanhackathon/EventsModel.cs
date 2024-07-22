using System;
using System.Collections.Generic;

namespace APIVanhackathon
{
    public class ListEvents
    {
        public List<EventsModel> Events { get; set; }

        public ListEvents()
        {
            Events = new List<EventsModel>();

            #region MockedData

            Events.Add(new EventsModel()
            {
                id = 23,
                name = "VanHackathon",
                country = "Canada",
                city = "Vancouver",
                state = "British Columbia",
                slug = "vanhackathon",
                promoted = false,
                startDate = DateTime.Parse("2019-11-15T00:00:00"),
                endDate = DateTime.Parse("2019-11-22T00:00:00"),
                startApplicationDate = DateTime.Parse("2019-10-03T00:00:00"),
                endApplicationDate = DateTime.Parse("2019-11-03T00:00:00"),
                isOnline = false,
                eventType = 4,
                applied = false,
                possibleToApply = false,
                subtitle = "November 15 - 22, 2019",
                theEvent = "<p><strong>Show companies what you can do and get hired in our virtual Hackathon!</strong></p>\n<p><br></p>\n<p>At VanHackathon, you’ll have the opportunity to develop a project for Canadian and European companies looking to hire international talent (yes, they do provide visa sponsorship + relocation!)</p>\n<p><br></p>\n<p>During the week-long event, you will engage with the company via a dedicated Slack channel, collaborate with other VanHackers, and do a demo of your project.</p>\n<p><br></p>\n<p>The event will happen on the course of a week, but don't worry = we don't want you to spen over 20 hours working on your project. And remember = this is an online event!</p>\n<p><br></p>\n<p>Let your creativity go nuts!</p>\n<p><br></p>",
                theCandidates = "<p>To be eligible, you MUST complete both English and Code Verification (when applicable).</p>\n<p>Candidates from <strong>all tech backgrounds may apply!</strong></p>\n<p>Here are some of the most in-demand skills = Java, JavaScript, Ruby, Python, .NET, PHP, C/C++, iOS, Android and React Native. DevOps, QA Engineers, Machine Learning Engineers and UI/UX designers are also welcome!</p>\n<p><br></p>\n<p>Do you have the skills? Have gotten verified? Well, then. <strong>Apply to attend!</strong></p>",
                flag = "canada",
                cover = "vanhackathonCover.jpg",
                thumb = "vanhackathonThumb.jpg",
                className = "li-thumb-acdion-vht"
            });
            Events.Add(new EventsModel() {
              id = 20,
              name = "Leap Vancouver - Job Fair",
              country = "Canada",
              city = "Vancouver",
              state = "British Columbia",
              slug = "leap-vancouver---job-fair",
              promoted = false,
              startDate = DateTime.Parse("2019-12-02T00:00:00"),
              endDate = DateTime.Parse("2019-12-04T00:00:00"),
              startApplicationDate = DateTime.Parse("2019-08-23T00:00:00"),
              endApplicationDate = DateTime.Parse("2019-11-30T00:00:00"),
              isOnline = false,
              eventType = 1,
              applied = false,
              possibleToApply = true,
              subtitle = "December 2 - 04, 2019",
              theEvent = "<p>VanHack is bringing to Vancouver on 2 until 4 December a Leap for Tech Talents who want to fuel the growth of Canada's tech market. Some of the best companies in Canada will be attending the fair, in hopes of filling over 40 positions.</p>\r\n<p>This is an amazing chance to do face-to-face interviews with international companies and land a job in Canada. Don't miss it!</p>",
              theCandidates = "<p>VanHack is looking for candidates with 4 or more years of professional experience.</p>\r\n<p>Candidates also need to have advanced or fluent English and be able to attend the Leap event on 2 until 4 December in person.</p>\r\n<p>Most importantly, candidates must be willing to get a job in Canada, and to relocate in 2 months.</p>",
              flag = "canada",
              cover = "leapVancouverCover.jpg",
              thumb = "leapVancouverThumb.jpg",
              className = "li-thumb-acdion-vcv"
            });
            Events.Add(new EventsModel() {
              id = 27,
              name = "Leap Ontario",
              country = "Canada",
              city = "Toronto",
              state = "Ontario",
              slug = "leap-ontario",
              promoted = false,
              startDate = DateTime.Parse("2020-02-03T00:00:00"),
              endDate = DateTime.Parse("2020-02-06T00:00:00"),
              startApplicationDate = DateTime.Parse("2019-10-28T00:00:00"),
              endApplicationDate = DateTime.Parse("2020-01-25T00:00:00"),
              isOnline = false,
              eventType = 1,
              applied = false,
              possibleToApply = true,
              subtitle = "February 3 - 06, 2020",
              theEvent = "<p>VanHack is bringing to Toronto on 3 until 6 February a Leap for Tech Talents who want to fuel the growth of Canada'stech market. Some of the best companies in ONTARIO will be attending the fair, in hopes of filling over 60 positions.</p>\r\n<p>This is an amazing chance to do face-to-face interviews with international companies and land a job abroad. Don't miss it!</p>",
              theCandidates = "<p>VanHack is looking for candidates with 4 or more years of professional experience.</p>\r\n<p>Candidates also need to have advanced or fluent English and be able to attend the Leap event on 3 until 6 February in person.</p>\r\n<p>Most importantly, candidates must be willing to get a job in Canada, and to relocate in the first semester of 2020.</p>",
              flag = "canada",
              cover = "leapOntarioCover.jpg",
              thumb = "leapOntarioThumb.jpg",
              className = "li-thumb-acdion-ont"
            });
            Events.Add(new EventsModel() {
              id = 28,
              name = "Leap Calgary",
              country = "Canada",
              city = "Calgary",
              state = "Alberta",
              slug = "leap-calgary",
              promoted = false,
              startDate = DateTime.Parse("2020-02-24T00:00:00"),
              endDate = DateTime.Parse("2020-02-27T00:00:00"),
              startApplicationDate = DateTime.Parse("2019-10-30T00:00:00"),
              endApplicationDate = DateTime.Parse("2020-02-10T00:00:00"),
              isOnline = false,
              eventType = 1,
              applied = false,
              possibleToApply = true,
              subtitle = "February 24 - 27, 2020",
              theEvent = "<p>VanHack is bringing to Calgary on 24 until 27 February a Leap for Tech Talents who want to fuel the growth of Canada's tech market. Some of the best companies in Canada will be attending the fair, in hopes of filling over 60 positions.</p>\n<p>This is an amazing chance to do face-to-face interviews with international companies and land a job abroad. Don't miss it!</p>",
              theCandidates = "<p>VanHack is looking for candidates with 4 or more years of professional experience.</p>\n<p>Candidates also need to have advanced or fluent English and be able to attend the Leap event on 24 until 27 February in person.</p>\n<p>Most importantly, candidates must be willing to get a job in Canada, and to relocate in the first semester of 2020.</p>",
              flag = "canada",
              cover = "leapCalgaryCover.jpg",
              thumb = "leapCalgaryThumb.jpg",
              className = "li-thumb-acdion-cal"
            });
            Events.Add(new EventsModel() {
              id = 22,
              name = "Colombia Recruiting Mission",
              country = "Colombia",
              city = "Medellín",
              state = "Antioquia",
              slug = "colombia-recruiting-mission",
              promoted = false,
              startDate = DateTime.Parse("2020-03-07T00:00:00"),
              endDate = DateTime.Parse("2020-03-08T00:00:00"),
              startApplicationDate = DateTime.Parse("2019-09-24T00:00:00"),
              endApplicationDate = DateTime.Parse("2020-02-14T00:00:00"),
              isOnline = false,
              eventType = 0,
              applied = false,
              possibleToApply = true,
              subtitle = "March 7 - 08, 2020",
              theEvent = "<p>VanHack is bringing to Medellin on <strong>March 7 and 8</strong>, 2020, a <strong>Recruiting Mission</strong> for <strong>Tech Talents</strong> who want to fuel the growth of Canada's and Europe's tech market. Some of the <strong>best companies in North America and Europe </strong>will be attending the fair, in hopes of filling over 50 positions.</p>\n<p>This is an amazing chance to do face-to-face interviews with international companies and land a job abroad. <strong>Don't miss it!</strong></p>",
              theCandidates = "<p>VanHack is looking for candidates with 3 or more years of professional experience.</p>\n<p>Candidates also need to have advanced or fluent English and be able to attend the Mission event on 7 &amp; 8 March in person.</p>\n<p>Most importantly, candidates must be willing to get a job in Canada and/or Europe, and to relocate in the first semester of 2020.</p>",
              flag = "colombia",
              cover = "colombiaMissionCover.jpg",
              thumb = "colombiaMissionThumb.jpg",
              className = "li-thumb-acdion-col"
            });
            Events.Add(new EventsModel() {
              id = 29,
              name = "Leap MTL",
              country = "Canada",
              city = "Montréal",
              state = "Quebec",
              slug = "leap-mtl",
              promoted = false,
              startDate = DateTime.Parse("2020-03-09T00:00:00"),
              endDate = DateTime.Parse("2020-03-12T00:00:00"),
              startApplicationDate = DateTime.Parse("2019-10-31T00:00:00"),
              endApplicationDate = DateTime.Parse("2020-03-01T00:00:00"),
              isOnline = false,
              eventType = 1,
              applied = false,
              possibleToApply = true,
              subtitle = "March 9 - 12, 2020",
              theEvent = "<p>VanHack is bringing to Montréal on 9 until 12 March a Leap for Tech Talents who want to fuel the growth of Canada's tech market. Some of the best companies in Canada will be attending the fair, in hopes of filling over 40 positions.</p>\n<p>This is an amazing chance to do face-to-face interviews with international companies and land a job abroad. Don't miss it!</p>",
              theCandidates = "<p>VanHack is looking for candidates with 4 or more years of professional experience.</p>\n<p>Candidates also need to have advanced or fluent English and be able to attend the Leap event on 9 until 12 March in person.</p>\n<p>Most importantly, candidates must be willing to get a job in Canada and to relocate in the first semester of 2020.</p>",
              flag = "canada",
              cover = "leapMTLCover.jpg",
              thumb = "leapMTLThumb.jpg",
              className = "li-thumb-acdion-mtl"
            });
            Events.Add(new EventsModel() {
              id = 30,
              name = "Leap Vancouver",
              country = "Canada",
              city = "Vancouver",
              state = "British Columbia",
              slug = "leap-vancouver",
              promoted = false,
              startDate = DateTime.Parse("2020-03-30T00:00:00"),
              endDate = DateTime.Parse("2020-04-02T00:00:00"),
              startApplicationDate = DateTime.Parse("2019-10-31T00:00:00"),
              endApplicationDate = DateTime.Parse("2020-03-08T00:00:00"),
              isOnline = false,
              eventType = 1,
              applied = false,
              possibleToApply = true,
              subtitle = "March 30 - April 2, 2020",
              theEvent = "<p>VanHack is bringing to Vancouver on 30 until 2 April a Leap for Tech Talents who want to fuel the growth of Canada's tech market. Some of the best companies in Canada will be attending the fair, in hopes of filling over 40 positions.</p>\n<p>This is an amazing chance to do face-to-face interviews with international companies and land a job abroad. Don't miss it!</p>",
              theCandidates = "<p>VanHack is looking for candidates with 5 or more years of professional experience.</p>\n<p>Candidates also need to have advanced or fluent English and be able to attend the Leap event on 30 until 2 April in person.</p>\n<p>Most importantly, candidates must be willing to get a job in Canada , and to relocate in the first semester of 2020.</p>",
              flag = "canada",
              cover = "leapVancouver2Cover.jpg",
              thumb = "leapVancouver2Thumb.jpg",
              className = "li-thumb-acdion-vc2"
            });

            #region Promoted - Highlights Events

            Events.Add(new EventsModel() {
              id = 25,
              name = "Relocation Summit 2019",
              country = "Canada",
              city = "Vancouver",
              state = "British Columbia",
              slug = "relocation-summit-2019",
              promoted = true,
              startDate = DateTime.Parse("2019-11-27T00:00:00"),
              endDate = DateTime.Parse("2019-12-04T00:00:00"),
              startApplicationDate = DateTime.Parse("2019-10-10T00:00:00"),
              endApplicationDate = DateTime.Parse("2019-11-26T00:00:00"),
              isOnline = false,
              eventType = 2,
              applied = false,
              possibleToApply = true,
              subtitle = "November 27 - December 4, 2019",
              theEvent = "<p>The new edition of <strong>VanHack Relocation Summit</strong> brings together insights and lessons from exceptional leaders, makers, and innovators in the international tech market - for<strong> 8 days</strong> of inspired conversation and purposeful networking.&nbsp;</p>\n<p>Join us to start changing your life = be part of the biggest online event for <strong>Tech Talent</strong> who want to relocate to Canada or Europe and get closer to your dream job abroad.</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>What to expect from the Relocation Summit?</strong></h2>\n<h2><br></h2>\n<p><strong>Perfect your skills</strong></p>\n<p>An intense week of content to help tech talents like you improve your skills, get the mindset and start your journey to get hired abroad.</p>\n<p><strong>Network and see what your peers are doing</strong></p>\n<p>Not only meet great professionals from the tech industry in Canada and Europe but you will also have the chance to meet people going through the same journey as you toward your job abroad.&nbsp;</p>\n<p><strong>Learn from your tech heroes&nbsp;</strong></p>\n<p>Hear from people that are part of the tech market in Canada and Europe - and the ones who went through the same path as you are now. Learn from the best to make your journey to find a job abroad smoother. &nbsp;</p>\n<p><strong>Make your dreams happen!</strong></p>\n<p>Relocation Summit is a great opportunity to help you turn your dream into a plan and make them happen! Start your journey to find an amazing job abroad, relocate and start a new life.</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Who should attend?</strong></h2>\n<h2><br></h2>\n<p>Our VanHack Relocation Summit is a virtual conference and networking event for absolutely everyone involved in the development and IT, and are looking to find a tech job abroad.&nbsp;</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Where? When? How?</strong></h2>\n<h2><br></h2>\n<p>Nov 27th - Dec 4th | Online - You can watch from everywhere in the world!</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Last year numbers</strong></h2>\n<h2><br></h2>\n<p><strong>+11.000 </strong>participants</p>\n<p><strong>+18 </strong>hours of content</p>\n<p><strong>+20</strong> speakers</p>",
              theCandidates = "<p>VanHack is looking for candidates with 3 or more years of professional experience.</p>\n  <p>Candidates also need to have advanced or fluent English and be able to attend the Webinar event on 27 until 4 December in person.</p>\n  <p>Most importantly, candidates must be willing to get a job in Canada and/or Europe, and to relocate in the second semester of 2019.</p>",
              flag = "canada",
              cover = "imgBanner1.png",
              thumb = "imgThumb1.png",
              className = "li-thumb-acdion-tb1"
            });

            Events.Add(new EventsModel()
            {
                id = 31,
                name = "Relocation Summit 2019",
                country = "Canada",
                city = "Vancouver",
                state = "British Columbia",
                slug = "relocation-summit-2019",
                promoted = true,
                startDate = DateTime.Parse("2019-11-27T00:00:00"),
                endDate = DateTime.Parse("2019-12-04T00:00:00"),
                startApplicationDate = DateTime.Parse("2019-10-10T00:00:00"),
                endApplicationDate = DateTime.Parse("2019-11-26T00:00:00"),
                isOnline = false,
                eventType = 2,
                applied = false,
                possibleToApply = true,
                subtitle = "November 27 - December 4, 2019",
                theEvent = "<p>The new edition of <strong>VanHack Relocation Summit</strong> brings together insights and lessons from exceptional leaders, makers, and innovators in the international tech market - for<strong> 8 days</strong> of inspired conversation and purposeful networking.&nbsp;</p>\n<p>Join us to start changing your life = be part of the biggest online event for <strong>Tech Talent</strong> who want to relocate to Canada or Europe and get closer to your dream job abroad.</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>What to expect from the Relocation Summit?</strong></h2>\n<h2><br></h2>\n<p><strong>Perfect your skills</strong></p>\n<p>An intense week of content to help tech talents like you improve your skills, get the mindset and start your journey to get hired abroad.</p>\n<p><strong>Network and see what your peers are doing</strong></p>\n<p>Not only meet great professionals from the tech industry in Canada and Europe but you will also have the chance to meet people going through the same journey as you toward your job abroad.&nbsp;</p>\n<p><strong>Learn from your tech heroes&nbsp;</strong></p>\n<p>Hear from people that are part of the tech market in Canada and Europe - and the ones who went through the same path as you are now. Learn from the best to make your journey to find a job abroad smoother. &nbsp;</p>\n<p><strong>Make your dreams happen!</strong></p>\n<p>Relocation Summit is a great opportunity to help you turn your dream into a plan and make them happen! Start your journey to find an amazing job abroad, relocate and start a new life.</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Who should attend?</strong></h2>\n<h2><br></h2>\n<p>Our VanHack Relocation Summit is a virtual conference and networking event for absolutely everyone involved in the development and IT, and are looking to find a tech job abroad.&nbsp;</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Where? When? How?</strong></h2>\n<h2><br></h2>\n<p>Nov 27th - Dec 4th | Online - You can watch from everywhere in the world!</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Last year numbers</strong></h2>\n<h2><br></h2>\n<p><strong>+11.000 </strong>participants</p>\n<p><strong>+18 </strong>hours of content</p>\n<p><strong>+20</strong> speakers</p>",
                theCandidates = "<p>VanHack is looking for candidates with 3 or more years of professional experience.</p>\n  <p>Candidates also need to have advanced or fluent English and be able to attend the Webinar event on 27 until 4 December in person.</p>\n  <p>Most importantly, candidates must be willing to get a job in Canada and/or Europe, and to relocate in the second semester of 2019.</p>",
                flag = "canada",
                cover = "imgBanner2.png",
                thumb = "imgThumb2.png",
                className = "li-thumb-acdion-tb2"
            });

            Events.Add(new EventsModel()
            {
                id = 32,
                name = "Relocation Summit 2019",
                country = "Canada",
                city = "Vancouver",
                state = "British Columbia",
                slug = "relocation-summit-2019",
                promoted = true,
                startDate = DateTime.Parse("2019-11-27T00:00:00"),
                endDate = DateTime.Parse("2019-12-04T00:00:00"),
                startApplicationDate = DateTime.Parse("2019-10-10T00:00:00"),
                endApplicationDate = DateTime.Parse("2019-11-26T00:00:00"),
                isOnline = false,
                eventType = 2,
                applied = false,
                possibleToApply = true,
                subtitle = "November 27 - December 4, 2019",
                theEvent = "<p>The new edition of <strong>VanHack Relocation Summit</strong> brings together insights and lessons from exceptional leaders, makers, and innovators in the international tech market - for<strong> 8 days</strong> of inspired conversation and purposeful networking.&nbsp;</p>\n<p>Join us to start changing your life = be part of the biggest online event for <strong>Tech Talent</strong> who want to relocate to Canada or Europe and get closer to your dream job abroad.</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>What to expect from the Relocation Summit?</strong></h2>\n<h2><br></h2>\n<p><strong>Perfect your skills</strong></p>\n<p>An intense week of content to help tech talents like you improve your skills, get the mindset and start your journey to get hired abroad.</p>\n<p><strong>Network and see what your peers are doing</strong></p>\n<p>Not only meet great professionals from the tech industry in Canada and Europe but you will also have the chance to meet people going through the same journey as you toward your job abroad.&nbsp;</p>\n<p><strong>Learn from your tech heroes&nbsp;</strong></p>\n<p>Hear from people that are part of the tech market in Canada and Europe - and the ones who went through the same path as you are now. Learn from the best to make your journey to find a job abroad smoother. &nbsp;</p>\n<p><strong>Make your dreams happen!</strong></p>\n<p>Relocation Summit is a great opportunity to help you turn your dream into a plan and make them happen! Start your journey to find an amazing job abroad, relocate and start a new life.</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Who should attend?</strong></h2>\n<h2><br></h2>\n<p>Our VanHack Relocation Summit is a virtual conference and networking event for absolutely everyone involved in the development and IT, and are looking to find a tech job abroad.&nbsp;</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Where? When? How?</strong></h2>\n<h2><br></h2>\n<p>Nov 27th - Dec 4th | Online - You can watch from everywhere in the world!</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Last year numbers</strong></h2>\n<h2><br></h2>\n<p><strong>+11.000 </strong>participants</p>\n<p><strong>+18 </strong>hours of content</p>\n<p><strong>+20</strong> speakers</p>",
                theCandidates = "<p>VanHack is looking for candidates with 3 or more years of professional experience.</p>\n  <p>Candidates also need to have advanced or fluent English and be able to attend the Webinar event on 27 until 4 December in person.</p>\n  <p>Most importantly, candidates must be willing to get a job in Canada and/or Europe, and to relocate in the second semester of 2019.</p>",
                flag = "canada",
                cover = "imgBanner3.png",
                thumb = "imgThumb3.png",
                className = "li-thumb-acdion-tb3"
            });

            Events.Add(new EventsModel()
            {
                id = 33,
                name = "Relocation Summit 2019",
                country = "Canada",
                city = "Vancouver",
                state = "British Columbia",
                slug = "relocation-summit-2019",
                promoted = true,
                startDate = DateTime.Parse("2019-11-27T00:00:00"),
                endDate = DateTime.Parse("2019-12-04T00:00:00"),
                startApplicationDate = DateTime.Parse("2019-10-10T00:00:00"),
                endApplicationDate = DateTime.Parse("2019-11-26T00:00:00"),
                isOnline = false,
                eventType = 2,
                applied = false,
                possibleToApply = true,
                subtitle = "November 27 - December 4, 2019",
                theEvent = "<p>The new edition of <strong>VanHack Relocation Summit</strong> brings together insights and lessons from exceptional leaders, makers, and innovators in the international tech market - for<strong> 8 days</strong> of inspired conversation and purposeful networking.&nbsp;</p>\n<p>Join us to start changing your life = be part of the biggest online event for <strong>Tech Talent</strong> who want to relocate to Canada or Europe and get closer to your dream job abroad.</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>What to expect from the Relocation Summit?</strong></h2>\n<h2><br></h2>\n<p><strong>Perfect your skills</strong></p>\n<p>An intense week of content to help tech talents like you improve your skills, get the mindset and start your journey to get hired abroad.</p>\n<p><strong>Network and see what your peers are doing</strong></p>\n<p>Not only meet great professionals from the tech industry in Canada and Europe but you will also have the chance to meet people going through the same journey as you toward your job abroad.&nbsp;</p>\n<p><strong>Learn from your tech heroes&nbsp;</strong></p>\n<p>Hear from people that are part of the tech market in Canada and Europe - and the ones who went through the same path as you are now. Learn from the best to make your journey to find a job abroad smoother. &nbsp;</p>\n<p><strong>Make your dreams happen!</strong></p>\n<p>Relocation Summit is a great opportunity to help you turn your dream into a plan and make them happen! Start your journey to find an amazing job abroad, relocate and start a new life.</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Who should attend?</strong></h2>\n<h2><br></h2>\n<p>Our VanHack Relocation Summit is a virtual conference and networking event for absolutely everyone involved in the development and IT, and are looking to find a tech job abroad.&nbsp;</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Where? When? How?</strong></h2>\n<h2><br></h2>\n<p>Nov 27th - Dec 4th | Online - You can watch from everywhere in the world!</p>\n<p><br></p>\n<p><br></p>\n<h2><strong>Last year numbers</strong></h2>\n<h2><br></h2>\n<p><strong>+11.000 </strong>participants</p>\n<p><strong>+18 </strong>hours of content</p>\n<p><strong>+20</strong> speakers</p>",
                theCandidates = "<p>VanHack is looking for candidates with 3 or more years of professional experience.</p>\n  <p>Candidates also need to have advanced or fluent English and be able to attend the Webinar event on 27 until 4 December in person.</p>\n  <p>Most importantly, candidates must be willing to get a job in Canada and/or Europe, and to relocate in the second semester of 2019.</p>",
                flag = "canada",
                cover = "imgBanner4.png",
                thumb = "imgThumb4.png",
                className = "li-thumb-acdion-tb4"
            });

            #endregion

            #endregion
        }
    }

    public class EventsModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string slug { get; set; }
        public bool promoted { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime startApplicationDate { get; set; }
        public DateTime endApplicationDate { get; set; }
        public bool isOnline { get; set; }
        public int eventType { get; set; }
        public bool applied { get; set; }
        public bool possibleToApply { get; set; }
        public string subtitle { get; set; }
        public string theEvent { get; set; }
        public string theCandidates { get; set; }
        public string flag { get; set; }
        public string cover { get; set; }
        public string thumb { get; set; }
        public string className { get; set; }
    }

    #region MockedData



    #endregion
}
