namespace Cwk_ScientificCalculator
{
    partial class frmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSqrRoot = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnMsubtract = new System.Windows.Forms.Button();
            this.btnMplus = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnCloseBracket = new System.Windows.Forms.Button();
            this.btnOpenBracket = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnPowerOf = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtDisplay.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.White;
            this.txtDisplay.Location = new System.Drawing.Point(12, 11);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(399, 60);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(12, 349);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 52);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btn1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(93, 349);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 52);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btn2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(174, 349);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 52);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btn3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(12, 292);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 52);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btn4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btn4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(93, 292);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 52);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btn5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btn5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(174, 292);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 52);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btn6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btn6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(12, 234);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 52);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btn7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btn7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(93, 234);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 52);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btn8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btn8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(174, 234);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 52);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btn9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btn9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.ForeColor = System.Drawing.Color.White;
            this.btnBackspace.Location = new System.Drawing.Point(93, 177);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(75, 52);
            this.btnBackspace.TabIndex = 11;
            this.btnBackspace.Text = "⌫";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            this.btnBackspace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnBackspace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(12, 177);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 52);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.MidnightBlue;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(12, 409);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 52);
            this.button14.TabIndex = 14;
            this.button14.Text = ".";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.inputDot);
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.button14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.White;
            this.btnPlus.Location = new System.Drawing.Point(255, 409);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 52);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = " + ";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.Location = new System.Drawing.Point(255, 349);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 52);
            this.btnSubtract.TabIndex = 16;
            this.btnSubtract.Text = " - ";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnSubtract.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnSubtract.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(255, 292);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 52);
            this.btnMultiply.TabIndex = 17;
            this.btnMultiply.Text = " * ";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnMultiply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnMultiply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(255, 234);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 52);
            this.btnDivide.TabIndex = 18;
            this.btnDivide.Text = " / ";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnDivide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnDivide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.White;
            this.btnEquals.Location = new System.Drawing.Point(336, 349);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 112);
            this.btnEquals.TabIndex = 19;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            this.btnEquals.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnEquals.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnSqrRoot
            // 
            this.btnSqrRoot.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSqrRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrRoot.ForeColor = System.Drawing.Color.White;
            this.btnSqrRoot.Location = new System.Drawing.Point(336, 292);
            this.btnSqrRoot.Name = "btnSqrRoot";
            this.btnSqrRoot.Size = new System.Drawing.Size(75, 52);
            this.btnSqrRoot.TabIndex = 20;
            this.btnSqrRoot.Text = "√ ";
            this.btnSqrRoot.UseVisualStyleBackColor = false;
            this.btnSqrRoot.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnSqrRoot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnSqrRoot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(336, 120);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 52);
            this.btnLog.TabIndex = 21;
            this.btnLog.Text = "Log ";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnLog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnMsubtract
            // 
            this.btnMsubtract.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMsubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsubtract.ForeColor = System.Drawing.Color.White;
            this.btnMsubtract.Location = new System.Drawing.Point(336, 77);
            this.btnMsubtract.Name = "btnMsubtract";
            this.btnMsubtract.Size = new System.Drawing.Size(75, 38);
            this.btnMsubtract.TabIndex = 24;
            this.btnMsubtract.Text = "M-";
            this.btnMsubtract.UseVisualStyleBackColor = false;
            this.btnMsubtract.Click += new System.EventHandler(this.btnMsubtract_Click);
            this.btnMsubtract.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnMsubtract.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnMplus
            // 
            this.btnMplus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMplus.ForeColor = System.Drawing.Color.White;
            this.btnMplus.Location = new System.Drawing.Point(255, 77);
            this.btnMplus.Name = "btnMplus";
            this.btnMplus.Size = new System.Drawing.Size(75, 38);
            this.btnMplus.TabIndex = 25;
            this.btnMplus.Text = "M+";
            this.btnMplus.UseVisualStyleBackColor = false;
            this.btnMplus.Click += new System.EventHandler(this.btnMplus_Click);
            this.btnMplus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnMplus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMS.ForeColor = System.Drawing.Color.White;
            this.btnMS.Location = new System.Drawing.Point(174, 77);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(75, 38);
            this.btnMS.TabIndex = 26;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            this.btnMS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnMS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.ForeColor = System.Drawing.Color.White;
            this.btnMR.Location = new System.Drawing.Point(93, 77);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(75, 38);
            this.btnMR.TabIndex = 27;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            this.btnMR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnMR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.ForeColor = System.Drawing.Color.White;
            this.btnMC.Location = new System.Drawing.Point(12, 77);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(75, 38);
            this.btnMC.TabIndex = 28;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            this.btnMC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnMC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnCloseBracket
            // 
            this.btnCloseBracket.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCloseBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseBracket.ForeColor = System.Drawing.Color.White;
            this.btnCloseBracket.Location = new System.Drawing.Point(336, 177);
            this.btnCloseBracket.Name = "btnCloseBracket";
            this.btnCloseBracket.Size = new System.Drawing.Size(75, 52);
            this.btnCloseBracket.TabIndex = 29;
            this.btnCloseBracket.Text = " )";
            this.btnCloseBracket.UseVisualStyleBackColor = false;
            this.btnCloseBracket.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnCloseBracket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnCloseBracket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnOpenBracket
            // 
            this.btnOpenBracket.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnOpenBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenBracket.ForeColor = System.Drawing.Color.White;
            this.btnOpenBracket.Location = new System.Drawing.Point(255, 177);
            this.btnOpenBracket.Name = "btnOpenBracket";
            this.btnOpenBracket.Size = new System.Drawing.Size(75, 52);
            this.btnOpenBracket.TabIndex = 30;
            this.btnOpenBracket.Text = "( ";
            this.btnOpenBracket.UseVisualStyleBackColor = false;
            this.btnOpenBracket.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnOpenBracket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnOpenBracket.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.ForeColor = System.Drawing.Color.White;
            this.btnCos.Location = new System.Drawing.Point(93, 120);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(75, 52);
            this.btnCos.TabIndex = 31;
            this.btnCos.Text = "Cos ";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnCos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnCos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.ForeColor = System.Drawing.Color.White;
            this.btnSin.Location = new System.Drawing.Point(12, 120);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(75, 52);
            this.btnSin.TabIndex = 32;
            this.btnSin.Text = "Sin ";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnSin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnSin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnPowerOf
            // 
            this.btnPowerOf.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPowerOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerOf.ForeColor = System.Drawing.Color.White;
            this.btnPowerOf.Location = new System.Drawing.Point(336, 234);
            this.btnPowerOf.Name = "btnPowerOf";
            this.btnPowerOf.Size = new System.Drawing.Size(75, 52);
            this.btnPowerOf.TabIndex = 34;
            this.btnPowerOf.Text = " ^ ";
            this.btnPowerOf.UseVisualStyleBackColor = false;
            this.btnPowerOf.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnPowerOf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnPowerOf.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.ForeColor = System.Drawing.Color.White;
            this.btnExp.Location = new System.Drawing.Point(255, 120);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(75, 52);
            this.btnExp.TabIndex = 35;
            this.btnExp.Text = "Exp ";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnExp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnExp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.ForeColor = System.Drawing.Color.White;
            this.btnTan.Location = new System.Drawing.Point(174, 120);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(75, 52);
            this.btnTan.TabIndex = 36;
            this.btnTan.Text = "Tan ";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnTan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnTan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(93, 408);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 52);
            this.btn0.TabIndex = 37;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btn0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btn0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.Location = new System.Drawing.Point(174, 409);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 52);
            this.btnMod.TabIndex = 38;
            this.btnMod.Text = " % ";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.inputNumberOrOperator);
            this.btnMod.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPressEffect);
            this.btnMod.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReleaseEffect);
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.Color.MidnightBlue;
            this.ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ans.ForeColor = System.Drawing.Color.White;
            this.ans.Location = new System.Drawing.Point(174, 178);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(75, 52);
            this.ans.TabIndex = 39;
            this.ans.Text = "ans";
            this.ans.UseVisualStyleBackColor = false;
            this.ans.Click += new System.EventHandler(this.ans_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(423, 472);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnPowerOf);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnOpenBracket);
            this.Controls.Add(this.btnCloseBracket);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMplus);
            this.Controls.Add(this.btnMsubtract);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSqrRoot);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "frmCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnSqrRoot;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnMsubtract;
        private System.Windows.Forms.Button btnMplus;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnCloseBracket;
        private System.Windows.Forms.Button btnOpenBracket;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnPowerOf;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button ans;
    }
}

