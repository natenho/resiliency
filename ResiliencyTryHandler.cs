using System;

namespace Winsys.ApplicationFramework.Helpers
{
    /// <summary>
    /// Permite manipular o evento de cada tentativa da classe de <see cref="Resiliency"/>
    /// </summary>
    public class ResiliencyTryHandler<TException> where TException : Exception
    {
        #region Properties

        /// <summary>
        /// Opção para abortar o ciclo de tentativas
        /// </summary>
        public bool AbortRetry { get; set; }

        /// <summary>
        /// <see cref="Exception"/> a ser tratada
        /// </summary>
        public TException Exception { get; private set; }

        /// <summary>
        /// Identifca o número da tentativa atual
        /// </summary>
        public int CurrentTry { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Instancia um manipulador de tentativa. É utilizado internamente
        /// por <see cref="Resiliency"/> para permitir que o cliente altere o
        /// comportamento do ciclo de tentativas
        /// </summary>
        public ResiliencyTryHandler(TException exception, int currentTry)
        {
            Exception = exception;
            CurrentTry = currentTry;
        }

        #endregion

    }
}