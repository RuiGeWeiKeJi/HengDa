using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HengDaSponge
{
    public partial class FormChild : Form
    {
        public FormChild ( )
        {
            InitializeComponent( );
        }

        private void Form1_Load ( object sender ,EventArgs e )
        {
            ToolSelete.Enabled = toolAdd.Enabled = true;
            toolUpdate.Enabled = toolDelete.Enabled = toolSave.Enabled = toolCancel.Enabled = toolExmine.Enabled = toolPrint.Enabled = false;
        }

        //Query
        protected virtual void select ( )
        {

        }
        //Delete
        protected virtual void delete ( )
        {

        }
        //Add
        protected virtual void add ( )
        {

        }
        //Save
        protected virtual void save ( )
        {

        }
        //Cancel
        protected virtual void cancel ( )
        {

        }
        //Examine
        protected virtual void examine ( )
        {

        }
        //Update
        protected virtual void update ( )
        {
        }
        //print
        protected virtual void print ( )
        {
        }
        private void ToolSelete_Click ( object sender ,EventArgs e )
        {
            select( );
        }
        private void toolDelete_Click ( object sender ,EventArgs e )
        {
            delete( );
        }
        private void toolAdd_Click ( object sender ,EventArgs e )
        {
            add( );
        }
        private void toolUpdate_Click ( object sender ,EventArgs e )
        {
            update( );
        }
        private void toolSave_Click ( object sender ,EventArgs e )
        {
            save( );
        }
        private void toolCancel_Click ( object sender ,EventArgs e )
        {
            cancel( );
        }
        private void toolExmine_Click ( object sender ,EventArgs e )
        {
            examine( );
        }

        private void toolPrint_Click ( object sender ,EventArgs e )
        {
            print( );
        }
    }
}
