using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Dal
{
   public  class AllLibDal
    {
       public DataTable getAll()
       {
          const string sql = "select a1.*,a2.*,a3.*,a4.* from all1 a1,all2 a2,all3 a3,all4 a4 where a1.JOBID=a2.JOBID and a3.JOBID=a1.JOBID and a4.jobID=a1.JOBID";
           return new MySQLHelper().GetDataTable(sql);
       }


       //public void Test()
       //{
       //    DataTable dt = getAll();
       //    DataTable x = dt;
       //}

       public string getSCLById(string JOBID)
       {
           var str = "";
           var sql = "select " +
                    "SCL001 ,SCL002 ,SCL003 ,SCL004 ,SCL005 ," +
                            "SCL006 ,SCL007 ,SCL008 ,SCL009 ,SCL010 ," +
                            "SCL011 ,SCL012 ,SCL013 ,SCL014 ,SCL015 ," +
                            "SCL016 ,SCL017 ,SCL018 ,SCL019 ,SCL020 ," +
                            "SCL021 ,SCL022 ,SCL023 ,SCL024 ,SCL025 ," +
                            "SCL026 ,SCL027 ,SCL028 ,SCL029 ,SCL030 ," +
                            "SCL031 ,SCL032 ,SCL033 ,SCL034 ,SCL035 ," +
                            "SCL036 ,SCL037 ,SCL038 ,SCL039 ,SCL040 ," +
                            "SCL041 ,SCL042 ,SCL043 ,SCL044 ,SCL045 ," +
                            "SCL046 ,SCL047 ,SCL048 ,SCL049 ,SCL050 ," +
                            "SCL051 ,SCL052 ,SCL053 ,SCL054 ,SCL055 ," +
                            "SCL056 ,SCL057 ,SCL058 ,SCL059 ,SCL060 ," +
                            "SCL061 ,SCL062 ,SCL063 ,SCL064 ,SCL065 ," +
                            "SCL066 ,SCL067 ,SCL068 ,SCL069 ,SCL070 ," +
                            "SCL071 ,SCL072 ,SCL073 ,SCL074 ,SCL075 ," +
                            "SCL076 ,SCL077 ,SCL078 ,SCL079 ,SCL080 ," +
                            "SCL081 ,SCL082 ,SCL083 ,SCL084 ,SCL085 ," +
                            "SCL086 ,SCL087 ,SCL088 ,SCL089 ,SCL090 ," +
                            "SCL091 ,SCL092 ,SCL093 ,SCL094 ,SCL095 ," +
                            "SCL096 ,SCL097 ,SCL098 ,SCL099 ,SCL100, " +
                             "SCL101 ,SCL102 ,SCL103 ,SCL104 ,SCL105 ," +
                            "SCL106 ,SCL107 ,SCL108 ,SCL109 ,SCL110 ," +
                            "SCL111 ,SCL112 ,SCL113 ,SCL114 ,SCL115 ," +
                            "SCL116 ,SCL117 ,SCL118 ,SCL119 ,SCL120 ," +
                            "SCL121 ,SCL122 ,SCL123 ,SCL124 ,SCL125 ," +
                            "SCL126 ,SCL127 ,SCL128 ,SCL129 ,SCL130 ," +
                            "SCL131 ,SCL132 ,SCL133 ,SCL134 ,SCL135 ," +
                            "SCL136 ,SCL137 ,SCL138 ,SCL139 ,SCL140 ," +
                            "SCL141 ,SCL142 ,SCL143 ,SCL144 ,SCL145 ," +
                            "SCL146 ,SCL147 ,SCL148 ,SCL149 ,SCL150 ," +
                            "SCL151 ,SCL152 ,SCL153 ,SCL154 ,SCL155 ," +
                            "SCL156 ,SCL157 ,SCL158 ,SCL159 ,SCL160 ," +
                            "SCL161 ,SCL162 ,SCL163 ,SCL164 ,SCL165 ," +
                            "SCL166 ,SCL167 ,SCL168 ,SCL169 ,SCL170 ," +
                            "SCL171 ,SCL172 ,SCL173 ,SCL174 ,SCL175 ," +
                            "SCL176 ,SCL177 ,SCL178 ,SCL179 ,SCL180 ," +
                            "SCL181 ,SCL182 ,SCL183 ,SCL184 ,SCL185 ," +
                            "SCL186 ,SCL187 ,SCL188 ,SCL189 ,SCL190 ," +
                            "SCL191 ,SCL192 ,SCL193 ,SCL194 ,SCL195 ," +
                            "SCL196 ,SCL197 ,SCL198 ,SCL199 ,SCL200, " +
                            "SCL201 ,SCL202 ,SCL203 ,SCL204 ,SCL205 ," +
                              "SCL206 ,SCL207 ,SCL208 ,SCL209 ,SCL210 ," +
                              "SCL211 ,SCL212 ,SCL213 ,SCL214 ,SCL215 ," +
                              "SCL216 ,SCL217 ,SCL218 ,SCL219 ,SCL220 ," +
                              "SCL221 ,SCL222 ,SCL223 ,SCL224 ,SCL225 ," +
                              "SCL226 ,SCL227 ,SCL228 ,SCL229 ,SCL230 ," +
                              "SCL231 ,SCL232 ,SCL233 ,SCL234 ,SCL235 ," +
                              "SCL236 ,SCL237 ,SCL238 ,SCL239 ,SCL240 ," +
                              "SCL241 ,SCL242 ,SCL243 ,SCL244 ,SCL245 ," +
                              "SCL246 ,SCL247 ,SCL248 ,SCL249 ,SCL250 ," +
                              "SCL251 ,SCL252 ,SCL253 ,SCL254 ,SCL255 ," +
                              "SCL256 ,SCL257 ,SCL258 ,SCL259 ,SCL260 ," +
                              "SCL261 ,SCL262 ,SCL263 ,SCL264 ,SCL265 ," +
                              "SCL266 ,SCL267 ,SCL268 ,SCL269 ,SCL270 ," +
                              "SCL271 ,SCL272 ,SCL273 ,SCL274 ,SCL275 ," +
                              "SCL276 ,SCL277 ,SCL278 ,SCL279 ,SCL280 ," +
                              "SCL281 ,SCL282 ,SCL283 ,SCL284 ,SCL285 ," +
                              "SCL286 ,SCL287 ,SCL288 ,SCL289 ,SCL290 ," +
                              "SCL291 ,SCL292 ,SCL293 ,SCL294 ,SCL295 ," +
                              "SCL296 ,SCL297 ,SCL298 ,SCL299 ,SCL300," +
                              "SCL301 ,SCL302 ,SCL303 ,SCL304 ,SCL305 ," +
                                 "SCL306 ,SCL307 ,SCL308 ,SCL309 ,SCL310 ," +
                                 "SCL311 ,SCL312 ,SCL313 ,SCL314 ,SCL315 ," +
                                 "SCL316 ,SCL317 ,SCL318 ,SCL319 ,SCL320 ," +
                                 "SCL321 ,SCL322 ,SCL323 ,SCL324 ,SCL325 ," +
                                 "SCL326 ,SCL327 ,SCL328 ,SCL329 ,SCL330 ," +
                                 "SCL331 ,SCL332 ,SCL333 ,SCL334 ,SCL335 ," +
                                 "SCL336 ,SCL337 ,SCL338 ,SCL339 ,SCL340 ," +
                                 "SCL341 ,SCL342 ,SCL343 ,SCL344 ,SCL345 ," +
                                 "SCL346 ,SCL347 ,SCL348 ,SCL349 ,SCL350 ," +
                                 "SCL351 ,SCL352 ,SCL353 ,SCL354 ,SCL355 ," +
                                 "SCL356 ,SCL357 ,SCL358 ,SCL359 ,SCL360 ," +
                                 "SCL361 ,SCL362 ,SCL363 ,SCL364 ,SCL365 ," +
                                 "SCL366 ,SCL367 ,SCL368 ,SCL369 ,SCL370 ," +
                                 "SCL371 ,SCL372 ,SCL373 ,SCL374 ,SCL375 ," +
                                 "SCL376 ,SCL377 ,SCL378 ,SCL379 ,SCL380 ," +
                                 "SCL381 ,SCL382 ,SCL383 ,SCL384 ,SCL385 ," +
                                 "SCL386 ,SCL387 ,SCL388 ,SCL389 ,SCL390 ," +
                                 "SCL391 ,SCL392 ,SCL393 ,SCL394 ,SCL395 ," +
                                 "SCL396 ,SCL397 ,SCL398 ,SCL399 ,SCL400, " +
                                 "SCL401 ,SCL402 ,SCL403 ,SCL404 ,SCL405 ," +
                                   "SCL406 ,SCL407 ,SCL408 ,SCL409 ,SCL410 ," +
                                   "SCL411 ,SCL412 ,SCL413 ,SCL414 ,SCL415 ," +
                                   "SCL416 ,SCL417 ,SCL418 ,SCL419 ,SCL420 ," +
                                   "SCL421 ,SCL422 ,SCL423 ,SCL424 ,SCL425 ," +
                                   "SCL426 ,SCL427 ,SCL428 ,SCL429 ,SCL430 ," +
                                   "SCL431 ,SCL432 ,SCL433 ,SCL434 ,SCL435 ," +
                                   "SCL436 ,SCL437 ,SCL438 ,SCL439 ,SCL440 ," +
                                   "SCL441 ,SCL442 ,SCL443 ,SCL444 ,SCL445 ," +
                                   "SCL446 ,SCL447 ,SCL448 ,SCL449 ,SCL450 ," +
                                   "SCL451 ,SCL452 ,SCL453 ,SCL454 ,SCL455 ," +
                                   "SCL456 ,SCL457 ,SCL458 ,SCL459 ,SCL460 ," +
                                   "SCL461 ,SCL462 ,SCL463 ,SCL464 ,SCL465 ," +
                                   "SCL466 ,SCL467 ,SCL468 ,SCL469 ,SCL470 ," +
                                   "SCL471 ,SCL472 ,SCL473 ,SCL474 ,SCL475 ," +
                                   "SCL476 ,SCL477 ,SCL478 ,SCL479 ,SCL480 ," +
                                   "SCL481 ,SCL482 ,SCL483 ,SCL484 ,SCL485 ," +
                                   "SCL486 ,SCL487 ,SCL488 ,SCL489 ,SCL490 ," +
                                   "SCL491 ,SCL492 ,SCL493 ,SCL494 ,SCL495 ," +
                                   "SCL496 ,SCL497 ,SCL498 ,SCL499 ,SCL500 " +
                                    "SCL501 ,SCL502 ,SCL503 ,SCL504 ,SCL505 ," +
                            "SCL506 ,SCL507 ,SCL508 ,SCL509 ,SCL510 ," +
                            "SCL511 ,SCL512 ,SCL513 ,SCL514 ,SCL515 ," +
                            "SCL516 ,SCL517 ,SCL518 ,SCL519 ,SCL520 ," +
                            "SCL521 ,SCL522 ,SCL523 ,SCL524 ,SCL525 ," +
                            "SCL526 ,SCL527 ,SCL528 ,SCL529 ,SCL530 ," +
                            "SCL531 ,SCL532 ,SCL533 ,SCL534 ,SCL535 ," +
                            "SCL536 ,SCL537 ,SCL538 ,SCL539 ,SCL540 ," +
                            "SCL541 ,SCL542 ,SCL543 ,SCL544 ,SCL545 ," +
                            "SCL546 ,SCL547 ,SCL548 ,SCL549 ,SCL550 ," +
                            "SCL551 ,SCL552 ,SCL553 ,SCL554 ,SCL555 ," +
                            "SCL556 ,SCL557 ,SCL558 ,SCL559 ,SCL560 ," +
                            "SCL561 ,SCL562 ,SCL563 ,SCL564 ,SCL565 ," +
                            "SCL566 ,SCL567 ,SCL568 ,SCL569 ,SCL570 ," +
                            "SCL571 ,SCL572 ,SCL573 ,SCL574 ,SCL575 ," +
                            "SCL576 ,SCL577 ,SCL578 ,SCL579 ,SCL580 ," +
                            "SCL581 ,SCL582 ,SCL583 ,SCL584 ,SCL585 ," +
                            "SCL586 ,SCL587 ,SCL588 ,SCL589 ,SCL590 ," +
                            "SCL591 ,SCL592 ,SCL593 ,SCL594 ,SCL595 ," +
                            "SCL596 ,SCL597 ,SCL598 ,SCL599 ,SCL600 ," +
                             "SCL601 ,SCL602 ,SCL603 ,SCL604 ,SCL605 ," +
                               "SCL606 ,SCL607 ,SCL608 ,SCL609 ,SCL610 ," +
                               "SCL611 ,SCL612 ,SCL613 ,SCL614 ,SCL615 ," +
                               "SCL616 ,SCL617 ,SCL618 ,SCL619 ,SCL620 ," +
                               "SCL621 ,SCL622 ,SCL623 ,SCL624 ,SCL625 ," +
                               "SCL626 ,SCL627 ,SCL628 ,SCL629 ,SCL630 ," +
                               "SCL631 ,SCL632 ,SCL633 ,SCL634 ,SCL635 ," +
                               "SCL636 ,SCL637 ,SCL638 ,SCL639 ,SCL640 ," +
                               "SCL641 ,SCL642 ,SCL643 ,SCL644 ,SCL645 ," +
                               "SCL646 ,SCL647 ,SCL648 ,SCL649 ,SCL650 ," +
                               "SCL651 ,SCL652 ,SCL653 ,SCL654 ,SCL655 ," +
                               "SCL656 ,SCL657 ,SCL658 ,SCL659 ,SCL660 ," +
                               "SCL661 ,SCL662 ,SCL663 ,SCL664 ,SCL665 ," +
                               "SCL666 ,SCL667 ,SCL668 ,SCL669 ,SCL670 ," +
                               "SCL671 ,SCL672 ,SCL673 ,SCL674 ,SCL675 ," +
                               "SCL676 ,SCL677 ,SCL678 ,SCL679 ,SCL680 ," +
                               "SCL681 ,SCL682 ,SCL683 ,SCL684 ,SCL685 ," +
                               "SCL686 ,SCL687 ,SCL688 ,SCL689 ,SCL690 ," +
                               "SCL691 ,SCL692 ,SCL693 ,SCL694 ,SCL695 ," +
                               "SCL696 ,SCL697 ,SCL698 ,SCL699 ,SCL700 " +
                                "SCL701 ,SCL702 ,SCL703 ,SCL704 ,SCL705 ," +
                               "SCL706 ,SCL707 ,SCL708 ,SCL709 ,SCL710 ," +
                               "SCL711 ,SCL712 ,SCL713 ,SCL714 ,SCL715 " +
                               " from all5,all6,all7,all8,all9,all10,all11,all12 where all5.JOBID=" + JOBID + " and all6.JOBID=" + JOBID + " and all7.JOBID=" + JOBID + " and all8.JOBID=" + JOBID + " and all9.JOBID=" + JOBID + " and all10.JOBID=" + JOBID + " and all11.JOBID=" + JOBID + "  and all12.JOBID=" + JOBID;
           var dt = new MySQLHelper().GetDataTable(sql);

           for (var i = 0; i < dt.Columns.Count; i++)
           {
               if (double.Parse(dt.Rows[0][i].ToString()) > 0)
               {
                   str += dt.Columns[i].ColumnName+",";
               }
           }
           if (str != "")
           {
               str = str.Substring(0, str.Length - 1);
           }
           return str;
       }

       /// <summary>
       /// 根据columns得到数组
       /// 	double SKL01w[] = (new AllBeanDaoImpl()).getJobIDList("SKL01_1");
		/*double SKL11w[] = (new AllBeanDaoImpl()).getJobIDList("SKL11_1");
		double SKL19w[] = (new AllBeanDaoImpl()).getJobIDList("SKL19_1");
		double SKL21w[] = (new AllBeanDaoImpl()).getJobIDList("SKL21_1");
		double SKL30w[] = (new AllBeanDaoImpl()).getJobIDList("SKL30_1");
		double SYL01w[] = (new AllBeanDaoImpl()).getJobIDList("SYL01");
		double SYL02w[] = (new AllBeanDaoImpl()).getJobIDList("SYL02");
		double SYL03w[] = (new AllBeanDaoImpl()).getJobIDList("SYL03");
		double SYL04w[] = (new AllBeanDaoImpl()).getJobIDList("SYL04");
		double SYL05w[] = (new AllBeanDaoImpl()).getJobIDList("SYL05");
		double SYL06w[] = (new AllBeanDaoImpl()).getJobIDList("SYL06");
		double SYL07w[] = (new AllBeanDaoImpl()).getJobIDList("SYL07");
		double SYL08w[] = (new AllBeanDaoImpl()).getJobIDList("SYL08");
		double SYL09w[] = (new AllBeanDaoImpl()).getJobIDList("SYL09");
		double SYL10w[] = (new AllBeanDaoImpl()).getJobIDList("SYL10");
		double SYL11w[] = (new AllBeanDaoImpl()).getJobIDList("SYL11");
		double SYL12w[] = (new AllBeanDaoImpl()).getJobIDList("SYL12");
		double SYL13w[] = (new AllBeanDaoImpl()).getJobIDList("SYL13");
		double SYL14w[] = (new AllBeanDaoImpl()).getJobIDList("SYL14");
		double SYL15w[] = (new AllBeanDaoImpl()).getJobIDList("SYL15");
		double SYL16w[] = (new AllBeanDaoImpl()).getJobIDList("SYL16");*/
       /// </summary>
       /// <param name="columns"></param>
       /// <returns></returns>
       public double[] getJobIDList(string columns) {
           var sql = "select " + columns + " from all1,all2,all4 where  all1.JOBID =all2.jobid and all1.JOBID=all4.JOBID  order by all1.jobid";
           DataTable dt = new MySQLHelper().GetDataTable(sql);
           double[] re = null;
           if (dt == null || dt.Rows.Count <= 0) return null;
           re = new double[dt.Rows.Count];
           for (var i = 0; i < dt.Rows.Count; i++)
           {
               re[i] = double.Parse(dt.Rows[i][columns].ToString());
           }
           return re;
       
       }

       /*
        * 
        * 	double SKL01wi = (new AllBeanDaoImpl()).getJobIDList2("SKL01_1", JOBID);
		double SKL11wi = (new AllBeanDaoImpl()).getJobIDList2("SKL11_1", JOBID);
		double SKL19wi = (new AllBeanDaoImpl()).getJobIDList2("SKL19_1", JOBID);
		double SKL21wi = (new AllBeanDaoImpl()).getJobIDList2("SKL21_1", JOBID);
		double SKL30wi = (new AllBeanDaoImpl()).getJobIDList2("SKL30_1", JOBID);
		double SKL01Lir = (new AllBeanDaoImpl()).getJobIDList2("SKL01_2", JOBID);
		double SKL11Lir = (new AllBeanDaoImpl()).getJobIDList2("SKL11_2", JOBID);
		double SKL19Lir = (new AllBeanDaoImpl()).getJobIDList2("SKL19_2", JOBID);
		double SKL21Lir = (new AllBeanDaoImpl()).getJobIDList2("SKL21_2", JOBID);
		double SKL30Lir = (new AllBeanDaoImpl()).getJobIDList2("SKL30_2", JOBID);
		double SYL01wi = (new AllBeanDaoImpl()).getJobIDList2("SYL01", JOBID);
		double SYL02wi = (new AllBeanDaoImpl()).getJobIDList2("SYL02", JOBID);
		double SYL03wi = (new AllBeanDaoImpl()).getJobIDList2("SYL03", JOBID);
		double SYL04wi = (new AllBeanDaoImpl()).getJobIDList2("SYL04", JOBID);
		double SYL05wi = (new AllBeanDaoImpl()).getJobIDList2("SYL05", JOBID);
		double SYL06wi = (new AllBeanDaoImpl()).getJobIDList2("SYL06", JOBID);
		double SYL07wi = (new AllBeanDaoImpl()).getJobIDList2("SYL07", JOBID);
		double SYL08wi = (new AllBeanDaoImpl()).getJobIDList2("SYL08", JOBID);
		double SYL09wi = (new AllBeanDaoImpl()).getJobIDList2("SYL09", JOBID);
		double SYL10wi = (new AllBeanDaoImpl()).getJobIDList2("SYL10", JOBID);
		double SYL11wi = (new AllBeanDaoImpl()).getJobIDList2("SYL11", JOBID);
		double SYL12wi = (new AllBeanDaoImpl()).getJobIDList2("SYL12", JOBID);
		double SYL13wi = (new AllBeanDaoImpl()).getJobIDList2("SYL13", JOBID);
		double SYL14wi = (new AllBeanDaoImpl()).getJobIDList2("SYL14", JOBID);
		double SYL15wi = (new AllBeanDaoImpl()).getJobIDList2("SYL15", JOBID);
		double SYL16wi = (new AllBeanDaoImpl()).getJobIDList2("SYL16", JOBID);
        * */
       public double getJobIDList2(string columns, string jobid)
       {
           var sql = "select " + columns + " from all1,all2,all4 where all1.jobid=" + jobid + " and all2.jobid=" + jobid + " and all4.jobid=" + jobid + "  order by all1.jobid";
           DataTable dt = new MySQLHelper().GetDataTable(sql);

           return double.Parse(dt.Rows[0][columns].ToString());
       }

       public DataTable getByID(string jobId)
       {
           var sql = "select " +
                      "JOBID ,JOBNAME ,INST1R ,INST2I,INST3A ,INST4S ,INST5E ,INST6C , VAL1A ,VAL2I ,VAL3C ,VAL4R ,VAL5S ,VAL6W ,SKL01_1 ," +
                         "SKL01_2 , SKL02_1 ,SKL02_2 ,SKL03_1 ,SKL03_2 ,SKL04_1 ,SKL04_2,SKL05_1 ,SKL05_2 ,SKL06_1 ,SKL06_2 ,SKL07_1 ,SKL07_2 ," +
                          "SKL08_1 ,SKL08_2 ,SKL09_1 ,SKL09_2 ,SKL10_1 ,SKL10_2 ,SKL11_1 ,SKL11_2 ,SKL12_1 ,SKL12_2 ,SKL13_1 ,SKL13_2 ," +
                          "SKL14_1 ,SKL14_2 "
                      + "from all1 where JOBID=" + jobId + "";
           return new MySQLHelper().GetDataTable(sql);
       
       }

       public void Test()
       {

           string str = getSCLById("10008.0");
           string x = str;
       }

    }
}
