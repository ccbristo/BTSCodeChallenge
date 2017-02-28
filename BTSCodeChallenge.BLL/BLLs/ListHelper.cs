using System.Collections.Generic;

namespace BTSCodeChallenge.BLL.BLLs
{
    public static class ListHelper
    {
        /// <summary>
        /// The pros that I see for this solution is that it is rather simple.
        /// Seeing what it is doing is rather easy as it is using the built in
        /// sort function so that you only need to loop through the list once.
        /// 
        /// The cons could be that you don't have full controll over the sort function
        /// so you could be sacraficing some performance.  The same could be said about
        /// using the foreach.  Howerver, I think that it allows the code to be more
        /// readable.
        /// 
        /// I am not really sure what you could do to save memory.  I think it is rather
        /// well optimized, but there is probably something with lists and arrays that I
        /// am missing.
        /// 
        /// If this ever needed to do use another sourece for its data I would just throw
        /// that into a data layer.  However, this function shouldn't ever need to change.
        /// I would just set have another layer that converted those sources into a list
        /// and then passed to this function and vis versa.  I wouldn't change this function
        /// to try and have it do more than what it needs to.  Maybe I am not understanding
        /// the question.
        /// 
        /// I don't know that I fully understand what the intent of this question is, but I'll
        /// answer the two things I think it might be.  If you are meaning that mulitple sources
        /// can be adding to the list and does that change how my function would execute I would
        /// say no.  You can add what ever integer to this list you want and it will still work
        /// when you run it.  If you are asking how I would implement real-time updating to the
        /// list so that as someone added a value to it then they would see the new results.  I
        /// would use javascript (probably KO) to handle that.  I would set up a list and then
        /// create a subscribe function on that that would update the output list of list as it 
        /// was changed.
        /// 
        /// P.S. Your question doesn't specify what to do if there are pairs, but I think I like
        /// how my function will handle it.  It will simply create a new Run starting with the pair.
        /// I think this plays more into what a Run means in cards.  Hope that will suffice. 
        ///
        /// </summary>
        /// <param name="inputList">list of integers to be sorted into Runs</param>
        /// <returns>the input list sorted into multiple lists of Runs</returns>
        public static List<List<int>> FindConsecutiveSubListInListOfInts(List<int> inputList)
        {
            
            inputList.Sort();
            var outputList = new List<List<int>>();
            List<int> tempList = null;

            for (var i = 0; i < inputList.Count; i++)
            {
                if (i == 0 || inputList[i - 1] + 1 != inputList[i])
                {
                    if (tempList != null) outputList.Add(tempList);
                    tempList = new List<int>();
                }

                tempList.Add(inputList[i]);
            }

            outputList.Add(tempList);

            return outputList;
        }
    }
}
