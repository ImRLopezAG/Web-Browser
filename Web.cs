using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WebBrowser
{
  public partial class Web : Form
  {
    List<string> Fav = new List<string>();
    private void UpdateCBX()
    {
      foreach (string content in Fav)
      {
        CbxFav.Items.Add(content);
      }
    }
    public Web()
    {
      InitializeComponent();
    }
    private void Web_Load(object sender, EventArgs e)
    {

    }
    private void Web_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F5)
      {
        e.Handled = true;
        BtnReload.PerformClick();
      }
      if (e.KeyCode == Keys.Enter)
      {
        if (TxtSearch.Text.Trim() != string.Empty)
        {
          WbBrowser.Navigate(TxtSearch.Text);
        }
        if (CbxFav.Text.Trim() != string.Empty)
        {
          WbBrowser.Navigate(CbxFav.Text);
        }
      }

      if (e.KeyCode == Keys.Escape)
      {
        this.Close();
      }

    }
    private void BtnBack_Click(object sender, EventArgs e)
    {
      WbBrowser.GoBack();
    }

    private void BtnForward_Click(object sender, EventArgs e)
    {
      WbBrowser.GoForward();
    }

    private void BtnReload_Click(object sender, EventArgs e)
    {
      WbBrowser.Refresh();
    }

    private void BtnHome_Click(object sender, EventArgs e)
    {
      WbBrowser.GoHome();
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
      WbBrowser.Navigate(TxtSearch.Text);
    }

    private void BtnFav_Click(object sender, EventArgs e)
    {
      Fav.Add(WbBrowser.Url.ToString());
      UpdateCBX();
    }

    private void CbxFav_SelectedIndexChanged(object sender, EventArgs e)
    {
      WbBrowser.Navigate(CbxFav.SelectedItem.ToString());
    }


  }
}
