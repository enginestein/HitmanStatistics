public class SACombination {
    int nbShotsFired, nbCloseEncounters, nbHeadshots, nbAlerts, nbEnemiesK, nbEnemiesH, nbInnocentsK, nbInnocentsH;

    public SACombination(int sf, int ce, int hs, int al, int ek, int eh, int ik, int ih) {
        nbShotsFired = sf;
        nbCloseEncounters = ce;
        nbHeadshots = hs;
        nbAlerts = al;
        nbEnemiesK = ek;
        nbEnemiesH = eh;
        nbInnocentsK = ik;
        nbInnocentsH = ih;
    }

    public bool isSACombination(int sf, int ce, int hs, int al, int ek, int eh, int ik, int ih) {
        return (sf <= nbShotsFired && ce <= nbCloseEncounters && hs <= nbHeadshots && al <= nbAlerts && ek <= nbEnemiesK && eh <= nbEnemiesH && ik <= nbInnocentsK && ih <= nbInnocentsH);
    }
}
