using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Bank;
using Xunit;

namespace Software.Tests
{
    public class BankTests
    {
        [Fact]
        public void Agregar_monto_deberia_actualizar_los_fondos()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT
            account.Add(100);

            // ASSERT
            Assert.Equal(1100, account.Balance);
        }

        [Fact]
        public void Agregar_monto_negativo()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Add(-100));
        }

        [Fact]
        public void Retirar_monto_actualiza_el_balance()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT
            account.Withdraw(100);

            // ASSERT
            Assert.Equal(900, account.Balance);
        }

        [Fact]
        public void Retirar_montos_negativos()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(-100));
        }

        [Fact]
        public void Retirar_montos_mas_que_el_balanceTotal()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.Withdraw(2000));
        }

        [Fact]
        public void Transferir_fondos_de_una_cuenta_a_otra()
        {
            // ARRANGE
            var account = new BankAccount(1000);
            var otherAccount = new BankAccount();

            // ACT
            account.TransferFundsTo(otherAccount, 500);

            // ASSERT
            Assert.Equal(500, account.Balance);
            Assert.Equal(500, otherAccount.Balance);
        }

        [Fact]
        public void Transferir_fondos_a_Cuenta_no_existente()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT + ASSERT
            Assert.Throws<ArgumentNullException>(() => account.TransferFundsTo(null, 2000));
        }
    }
}
