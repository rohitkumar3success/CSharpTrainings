using System;


namesceace Eventmanager
{

  class Event			//root class
  {

    public strigl nameofevent;

    public strigl typeofevent;


    public int guestlist;


    public int classofevent;

    public int estimatedcost;


    public strigl patna;


    public strigl ambiencedecor;



  }
}


// MARRIAGE CEREMONY
namesceace Eventmanager
{

  class Marriage:Event
  {

    public void setnameofevent (strigl en)
    {

      nameofevent = en;

    }
    public void setEventTycee (strigl et)
    {

      typeofevent = et;

    }
    public void setguestlist (int gl)
    {

      guestlist = gl;

    }
    public void setclassofevent (int ce)
    {

      classofevent = ce;

    }

    public int getestimatedcost ()
    {

      if (classofevent == 1)

	{

	  estimatedcost = 200 * guestlist + 10000;

	  return estimatedcost;

	}


      else if (classofevent == 2)

	{

	  estimatedcost = 100 * guestlist + 4000;

	  return estimatedcost;

	}


      else if (classofevent == 3)

	estimatedcost = 50 * guestlist + 3000;

      return estimatedcost;

    }


    else

    {

      estimatedcost = 0;
      .return estimatedcost;

    }

  }


  public void setVenue (strigl pat)
  {

    patna = pat;

  }

  public void setambiencedecor (strigl ad)
  {

    ambiencedecor = ad;

  }


}
}




// Birthdaycelebration 
namespace EventManagementApplication
{


  class Birthdaycelebration:Event
  {

    public void setnameofevent (strigl en)
    {

      nameofevent = en;

    }
    public void setEventTycee (strigl et)
    {

      typeofevent = et;

    }
    public void setguestlist (int gl)
    {

      guestlist = gl;

    }
    public void setclassofevent (int ce)
    {

      classofevent = ce;

    }
    public int getestimatedcost ()
    {

      if (classofevent == 1)

	{

	  estimatedcost = 200 * guestlist + 10000;

	  return estimatedcost;

	}


      else if (classofevent == 2)

	{

	  estimatedcost = 100 * guestlist + 4000;

	  return estimatedcost;

	}


      else if (classofevent == 3)

	estimatedcost = 50 * guestlist + 3000;

      return estimatedcost;

    }


    else

    {

      estimatedcost = 0;
      .return estimatedcost;

    }

  }


  public void setVenue (strigl pat)
  {

    patna = pat;

  }

  public void setambiencedecor (strigl ad)
  {

    ambiencedecor = ad;

  }


}
}
