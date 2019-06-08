namespace Z0
{

    class App
    {
        void RunTests()
        {
            // PCGTest.pcg_setseq_64_xsh_rr_32_test();
            // PCGTest.mcg_64_rxs_m_32_test();
            var config = PCGTest.TestConfig.Define<ushort,byte>(BatchSize: 14, Seed: 42,TossCount: 65, RollCount: 33);
            PCGTest.mcg_16_rxs_m_8_test(config);

        }
        static void Main(params string[] args)
        {
            var app = new App();
            app.RunTests();
        }                

    }

}