using Bridge.Contract;
using ICSharpCode.NRefactory.CSharp;

namespace Bridge.Translator
{
    public class UnsafeBlock : AbstractEmitterBlock
    {
        public UnsafeBlock(IEmitter emitter, UnsafeStatement unsafeStatement)
            : base(emitter, unsafeStatement)
        {
            this.Emitter = emitter;
            this.UnsafeStatement = unsafeStatement;
        }

        public UnsafeStatement UnsafeStatement
        {
            get;
            set;
        }

        protected override void DoEmit()
        {
            VisitUnsafeStatementStatement();
        }

        protected void VisitUnsafeStatementStatement()
        {
            UnsafeStatement unsafeStatement = UnsafeStatement;

            Emitter.NoBraceBlock = unsafeStatement.Body;
            unsafeStatement.Body.AcceptVisitor(Emitter);
            Emitter.NoBraceBlock = null;
        }
    }
}