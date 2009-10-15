using SharpArchContrib.Data.NHibernate;
using SharpArchContrib.PostSharp.NHibernate;
using Tests.NHibernateTests;

namespace Tests.SharpArchContrib.PostSharp.NHibernate {
    public class SystemTransactionTestProvider : TransactionTestProviderBase, ITransactionTestProvider {
        protected override string TestEntityName {
            get { return "TransactionTest"; }
        }

        #region ITransactionTestProvider Members

        public string Name {
            get { return "PostSharp SystemTransactionTestProvider"; }
        }

        [Transaction]
        public override void DoCommit(string testEntityName) {
            base.DoCommit(testEntityName);
        }

        [Transaction(IsExceptionSilent = true)]
        public override void DoCommitSilenceException(string testEntityName) {
            base.DoCommitSilenceException(testEntityName);
        }

        [Transaction]
        public override void DoRollback() {
            base.DoRollback();
        }

        [Transaction]
        public override void DoNestedCommit() {
            base.DoNestedCommit();
        }

        [Transaction]
        public override void DoNestedForceRollback() {
            base.DoNestedInnerForceRollback();
        }

        [Transaction]
        public override void DoNestedInnerForceRollback() {
            base.DoNestedInnerForceRollback();
        }

        public void InitTransactionManager() {
            ServiceLocatorInitializer.Init(typeof(SystemTransactionManager));
        }

        #endregion
    }
}