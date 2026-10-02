public class cerFormat {
        
        private var evidencePieces = 0;
        private string[] essay;

        public cerFormat(int howMuchEvidence) {
            essay = new string[howMuchEvidence];
            evidencePieces = howMuchEvidence;
        }
        //bascially this is going to like, idk track how many paragraphs are needed.

        public String formatCer(string[] toFormat)
        {
                //this thing is basically going to take all of the evidence, reasoning, etc
                //get how much evidence so that it basically knows this:
                //format intro -> format evidence + reasoning together (one paragraph) for however many times as
                //we have evidence. then add conclusion or something

                /*in this process do intro -> random phrase from list for first evidence (also include like first, lastly
                etc), Random phrase from
                list for reasoning (this shows that, etc) then for conclusion, random phrase from list (in conclusion, etc)

                actually if i want i could i guess format intro and conclusion in their own thing, idk


                */
        }

}
