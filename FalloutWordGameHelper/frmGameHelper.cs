/*  Author:     Bryan Everson
 *  Date:       5/3/13
 *  Purpose:    In Fallout 3, there is a word game that gives the player a list of words,
 *              a "password" is among them, and the player gets 4 guesses to find it. With the first 3 
 *              guesses, the player is given the number of letters that the guess has in common
 *              with the password . This program is designed to take the list of words as input
 *              as well as the number of correct letters from each guess. With each guess, any words
 *              that do not have the same number of correct letters when compared to the guess will be 
 *              discarded, then the same for each subsequent list. The list from the second guess will
 *              discard any words that don't fit the qualification of both the first and second, and so on.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FalloutWordGameHelper
{
    public partial class frmGameHelper : Form
    {
        public frmGameHelper()
        {
            InitializeComponent();
        }

        string selectedWord = "";             //variable to hold word currently selected in listbox
        Words wordPool = new Words();        

        private void updateWordList()
        {
            lstWords.Items.Clear();
            for (int i = 0; i < wordPool.Count; i++)  
            {
                lstWords.Items.Add(wordPool[i]);
            }
        }

        private void addWord(string word)
        {
            clearErrors();
            if (!wordPool.Contains(word))              //if word is not in list already, add it to the collection and update listbox
            {
                wordPool.Add(word);
                updateWordList();
            }
            else
            {
                errorProvider1.SetError(txtWord, "List already has that word.");
            }
            txtWord.Clear();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (txtWord.Text != "")
            {
                addWord(txtWord.Text);
            }
        }

        private void clearErrors()
        {
            errorProvider1.SetError(txtWord, "");
            errorProvider1.SetError(nudCorrect,"");
        }

        private void btnSetGuess_Click(object sender, EventArgs e)
        {
            if(selectedWord.Length >= nudCorrect.Value)
            {
               wordPool.setGuess(selectedWord,(int)nudCorrect.Value);
               updateWordList();
            }else 
                errorProvider1.SetError(nudCorrect,"Correct characters cannot outnumber number of characters");
           
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWord = (string)lstWords.SelectedItem;  //set selected word variable to listbox selected item
            txtGuess.Text = selectedWord;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            btnAddWord.Enabled = false;
            txtWord.Clear();
            txtWord.Enabled = false;
        }
    }
}
