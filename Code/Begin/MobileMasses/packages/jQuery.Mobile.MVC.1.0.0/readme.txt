To enable default mobile view, you must add the following line as the last line in the Application_Start method in Global.asax.cs:

BundleMobileConfig.RegisterBundles(BundleTable.Bundles);
