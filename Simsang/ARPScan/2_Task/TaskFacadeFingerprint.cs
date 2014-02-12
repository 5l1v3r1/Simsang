﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

using Simsang.ARPScan.Main.Config;


namespace Simsang.ARPScan.SystemFingerprint
{
  public class TaskFacadeFingerprint
  {

    #region MEMBERS

    private static TaskFacadeFingerprint cInstance;
    private InfrastructureFacadeFingerprint cInfrastructure;

    #endregion


    #region PUBLIC

    /// <summary>
    /// 
    /// </summary>
    public TaskFacadeFingerprint()
    {
      cInfrastructure = InfrastructureFacadeFingerprint.getInstance();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static TaskFacadeFingerprint getInstance()
    {
      return cInstance ?? (cInstance = new TaskFacadeFingerprint());
    }



    /// <summary>
    /// 
    /// </summary>
    public void startFingerprint(FingerprintConfig pConfig)
    {
      cInfrastructure.startFingerprint(pConfig);
    }


    public String getSystenDetailsFile(String pMAC)
    {
      return cInfrastructure.getSystenDetailsFile(pMAC);
    }


    /// <summary>
    /// 
    /// </summary>
    public void stopFingerprint()
    {
      cInfrastructure.stopFingerprint();
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="pMACAddress"></param>
    public SystemDetails loadSystemDetails(String pMACAddress)
    {
      return cInfrastructure.loadSystemDetails(pMACAddress);
    }

    #endregion

  }

}
