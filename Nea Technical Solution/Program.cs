using System;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public static class Forms
    {
        public static MainMenu menu = new MainMenu(); 
        public static DjikstrasPage djikstra = new DjikstrasPage();
        public static KruskalPage kruskal = new KruskalPage();
        public static PrimsPage prims = new PrimsPage();
        public static PracticeQuestion recommendeQuestion = new PracticeQuestion();
        public static TutorialsPage tutorials = new TutorialsPage();
        public static PracticeDjikstra PracticeD = new PracticeDjikstra();
        public static UserLoginPage userLogin = new UserLoginPage(); // greets the user with a page which asks them to either sign in or create an account 
        public static SignUpPage signUp = new SignUpPage();
        public static SignInPage signIn = new SignInPage();
        public static DjikstraQuestionsPage DjikstraQuestions = new DjikstraQuestionsPage();
        public static PrimsQuestionPage Prims = new PrimsQuestionPage();
        public static RecommendMeAQuestion RecQs = new RecommendMeAQuestion();
        public static GraphForKruskalQuestionsPage KruskalsQuestionsGraph = new GraphForKruskalQuestionsPage();
        public static KruskalQuestionsPage KruskalQuestionsPage = new KruskalQuestionsPage();
        public static GraphForRecommendedQuestion GraphForRecommendedQuestions = new GraphForRecommendedQuestion();
        public static TestingMenu TestingMenu = new TestingMenu();
        public static TestPrimsTable TestingPrims = new TestPrimsTable();
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserLoginPage());
        }
    }
}
