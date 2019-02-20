﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTestSourceControl
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTestSourceControlRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("b61f8183-e443-458b-bfbb-ba758b49b021")]
    public partial class MyTestSourceControlRepository : RepoGenBaseFolder
    {
        static MyTestSourceControlRepository instance = new MyTestSourceControlRepository();
        MyTestSourceControlRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the MyTestSourceControlRepository element repository.
        /// </summary>
        [RepositoryFolder("b61f8183-e443-458b-bfbb-ba758b49b021")]
        public static MyTestSourceControlRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTestSourceControlRepository() 
            : base("MyTestSourceControlRepository", "/", null, 0, false, "b61f8183-e443-458b-bfbb-ba758b49b021", ".\\RepositoryImages\\MyTestSourceControlRepositoryb61f8183.rximgres")
        {
            _applicationundertest = new MyTestSourceControlRepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("b61f8183-e443-458b-bfbb-ba758b49b021")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("f9f4e0a2-5564-4a48-8acd-5e54cb9321a2")]
        public virtual MyTestSourceControlRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTestSourceControlRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("f9f4e0a2-5564-4a48-8acd-5e54cb9321a2")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/form[@processname='RxDemoApp']", parentFolder, 30000, null, true, "f9f4e0a2-5564-4a48-8acd-5e54cb9321a2", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f9f4e0a2-5564-4a48-8acd-5e54cb9321a2")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("f9f4e0a2-5564-4a48-8acd-5e54cb9321a2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}